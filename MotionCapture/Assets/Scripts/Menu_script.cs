using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menue_script : MonoBehaviour
{

    [SerializeField] GameObject pauseScreen;
    public void PauseGame()
    {
        Time.timeScale = 0f;
        pauseScreen.SetActive(true);

    }

    public void ResumeGame()
    {
        Time.timeScale = 1f;
        pauseScreen.SetActive(false);
    }

    public void Restart()
    {
        string scene = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(scene);
        Time.timeScale = 1f;
        Debug.Log("sceneswitch");
    }

    public void Level_page()
    {

        SceneManager.LoadScene("LevelsPage");
        Debug.Log("sceneswitch");
    }
}