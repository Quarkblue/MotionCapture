using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] sectionPrefabs;
    public GameObject[] obstaclePrefabs;
    public Transform playerTransform;  // Reference to the player's transform
    private float roadWidth = 10f;
    private int zPos = 10;
    private bool creatingSection = false;

    private Vector3 lastObstaclePosition = Vector3.zero;
    private List<GameObject> generatedSections = new List<GameObject>();

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }

        DestroyPassedSections();
    }

    IEnumerator GenerateSection()
    {
        int secNum = Random.Range(0, sectionPrefabs.Length);
        GameObject newSection = Instantiate(sectionPrefabs[secNum], new Vector3(3, 0, zPos), Quaternion.identity);
        generatedSections.Add(newSection);

        // Adjust zPos for the next section
        zPos += 20;

        SpawnObstacles(newSection);

        // Reduce the waiting time for faster generation
        yield return new WaitForSeconds(0.1f);

        creatingSection = false;
    }

    void SpawnObstacles(GameObject section)
    {
        float spawnRange = roadWidth / 2f;

        foreach (GameObject obstaclePrefab in obstaclePrefabs)
        {
            Vector3 obstaclePosition = FindValidObstaclePosition(spawnRange, section.transform.position.z);

            // Check if the obstacle collides with the player
            if (Vector3.Distance(obstaclePosition, playerTransform.position) < 2f)
            {
                continue; // Skip this obstacle if it's too close to the player
            }

            Instantiate(obstaclePrefab, obstaclePosition, Quaternion.identity);

            lastObstaclePosition = obstaclePosition;
        }
    }

    Vector3 FindValidObstaclePosition(float spawnRange, float sectionZPos)
    {
        Vector3 obstaclePosition;

        do
        {
            float randomX = Random.Range(-spawnRange, spawnRange);
            float obstacleZPos = sectionZPos + Random.Range(5f, 10f);

            obstaclePosition = new Vector3(randomX, 0.5f, obstacleZPos);
        } while (IsTooCloseToLastObstacle(obstaclePosition));

        return obstaclePosition;
    }

    bool IsTooCloseToLastObstacle(Vector3 currentObstaclePosition)
    {
        // Check if the current obstacle is too close to the last spawned obstacle
        float minDistance = 5f; // Adjust this value based on your requirements
        return Vector3.Distance(currentObstaclePosition, lastObstaclePosition) < minDistance;
    }

    void DestroyPassedSections()
    {
        float destroyZPos = playerTransform.position.z - 20f; // Adjust as needed

        // Destroy sections that have been passed by the player
        for (int i = 0; i < generatedSections.Count; i++)
        {
            if (generatedSections[i].transform.position.z < destroyZPos)
            {
                Destroy(generatedSections[i]);
                generatedSections.RemoveAt(i);
                i--;
            }
        }
    }

    public void GameOver()
    {
        // Set the game over flag
        // Additional game over logic can be added here if needed
        Debug.Log("Game Over");

        // Restart the game after a delay (adjust as needed)
        StartCoroutine(RestartGameAfterDelay(2f));
    }

    IEnumerator RestartGameAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Reload the current scene to restart the game
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
