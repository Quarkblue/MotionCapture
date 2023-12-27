using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GenerateLevel : MonoBehaviour
{
    public GameObject[] section;
    public GameObject[] obstaclePrefabs;
    private float roadWidth = 10f; // Adjust this based on your road width
    private int zPos = 10;
    private bool creatingSection = false;
    private int secNum;

    // Keep track of the last spawned obstacle position
    private Vector3 lastObstaclePosition = Vector3.zero;

    void Update()
    {
        if (creatingSection == false)
        {
            creatingSection = true;
            StartCoroutine(GenerateSection());
        }
    }

    IEnumerator GenerateSection()
    {
        secNum = Random.Range(0, 3);
        Instantiate(section[secNum], new Vector3(0, 0, zPos), Quaternion.identity);
        zPos += 20;

        // Spawn obstacles on the ground
        SpawnObstacles();

        yield return new WaitForSeconds(0.5f);

        creatingSection = false;
    }

    void SpawnObstacles()
    {
        float spawnRange = roadWidth / 2f;

        foreach (GameObject obstaclePrefab in obstaclePrefabs)
        {
            // Try to find a valid position for the obstacle
            Vector3 obstaclePosition = FindValidObstaclePosition(spawnRange);

            // Spawn the obstacle
            Instantiate(obstaclePrefab, obstaclePosition, Quaternion.identity);

            // Update the last spawned obstacle position
            lastObstaclePosition = obstaclePosition;
        }
    }

    Vector3 FindValidObstaclePosition(float spawnRange)
    {
        Vector3 obstaclePosition;

        do
        {
            // Generate a random position within the spawn range
            float randomX = Random.Range(-spawnRange, spawnRange);
            float obstacleZPos = zPos + Random.Range(5f, 10f); // Adjust the range based on your needs

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
