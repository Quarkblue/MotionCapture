using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Python.Runtime;
using TMPro;
using System.IO;
using Unity.VisualScripting;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public bool StartRecieving = true;
    public static GameManager Instance;
    public bool stopRecieving = false;
    public string movement;
    public string prevMove;

    public TextMeshProUGUI scoreText;
    private int score = 0;

    public GameObject[] vegetablePrefabs;
    public PlayerMove playerMoveScript;

    public int timer;
    public bool isPaused = false;
    public GameObject pauseMenu;

    public bool isGameOver;



    private void OnEnable()
    {
        EventManager.OnRightBend += MoveRight;
        EventManager.OnLeftBend += MoveLeft;
        EventManager.OnCenterBend += MoveCenter;
        EventManager.OnGameOver += OnGameOver;
    }

    private void Awake()
    {
        isGameOver = false;
        if (Instance == null)
        {
            Debug.Log("GameManager");
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        Time.timeScale = 0;
        prevMove = "";
        isPaused = false;
        StartCoroutine(WaitOnes());
        StartCoroutine(SpawnVegetables());
    }

    void Update()
    {
        if (timer <= 0 && !isGameOver)
        {
            if (isPaused == false)
            {
                Time.timeScale = 1;
            }
            if (movement == "Center" && movement != prevMove)
            {
                EventManager.CenterBendEvent();
            }
            else if (movement == "Left" && movement != prevMove)
            {
                EventManager.LeftBendEvent();
            }
            else if (movement == "Right" && movement != prevMove)
            {
                EventManager.RightBendEvent();
            }

            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Debug.Log("Pause");
                PauseUnPause();
            }
        }else if (isGameOver)
        {
            EventManager.GameOverEvent();
        }
    }

    private void OnDisable()
    {
        stopRecieving = true;
        EventManager.OnRightBend -= MoveRight;
        EventManager.OnLeftBend -= MoveLeft;
        EventManager.OnCenterBend -= MoveCenter;
    }

    private IEnumerator WaitOnes()
    {
        while (timer > 0 && true)
        {
            yield return new WaitForSecondsRealtime(1f);
            timer--;
        }
    }

    private IEnumerator SpawnVegetables()
    {
        while (true && timer <= 0)
        {
            yield return new WaitForSeconds(UnityEngine.Random.Range(5f, 10f));

            float spawnX = UnityEngine.Random.Range(-5f, 5f);
            float spawnZ = FindPlayerPosition() + 20f;

            GameObject selectedVegetablePrefab = vegetablePrefabs[UnityEngine.Random.Range(0, vegetablePrefabs.Length)];

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

    public void PauseUnPause()
    {
        if (isPaused == false)
        {
            isPaused = true;
            Time.timeScale = 0;
            pauseMenu.SetActive(true);
        }
        else
        {
            isPaused = false;
            Time.timeScale = 1;
            pauseMenu.SetActive(false);
        }
    }

    private void MoveLeft()
    {
        Debug.Log("Moving left");
        playerMoveScript.Move(-1);
        prevMove = "Left";
    }

    private void MoveRight()
    {
        Debug.Log("Moving right");
        playerMoveScript.Move(1);

        prevMove = "Right";
    }

    private void MoveCenter()
    {
        Debug.Log("Moving center");
        if (prevMove == "Left")
        {
            playerMoveScript.Move(1);
        }
        else if (prevMove == "Right")
        {
            playerMoveScript.Move(-1);
        }
        prevMove = "Center";
    }

    public void OnGameOver()
    {
        SaveDataInCSV();
        PlayerPrefs.SetInt("Score", score);
        PlayerPrefs.SetFloat("Time", timer);
        PlayerPrefs.Save();
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameOver");
    }

    public void SaveDataInCSV()
    {
        StreamWriter sw = new StreamWriter($"{Application.streamingAssetsPath}/UserData/User.csv");
        sw.WriteLine("Paitient Name,ID,Score,Time Take");
    }

}
