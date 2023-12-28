using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TextMeshProUGUI scoreText;
    private int score = 0;

    public GameObject[] vegetablePrefabs; 

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        StartCoroutine(SpawnVegetables());
    }

    private IEnumerator SpawnVegetables()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(5f, 10f));

            float spawnX = Random.Range(-5f, 5f);
            float spawnZ = FindPlayerPosition() + 20f;

            
            GameObject selectedVegetablePrefab = vegetablePrefabs[Random.Range(0, vegetablePrefabs.Length)];

            Instantiate(selectedVegetablePrefab, new Vector3(spawnX, 0.5f, spawnZ), Quaternion.identity);
        }
    }

    private float FindPlayerPosition()
    {
        GameObject player = GameObject.Find("Player");

        if (player != null)
        {
            return player.transform.position.z;
        }

        return 0f; 
    }

    public void CollectVegetable(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }
}
