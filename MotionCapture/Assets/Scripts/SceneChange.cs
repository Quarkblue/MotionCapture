using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class SceneChange : MonoBehaviour
{

    public void ChangeScene(string name)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(name);
    }

    public void StartProcess()
    {
        Process proc = new Process();
        proc.StartInfo.FileName = $"{Application.streamingAssetsPath}/Python-3.7.9/python.exe";
        proc.StartInfo.Arguments = $"{Application.streamingAssetsPath}/PythonScripts/MoCap.py";
        proc.StartInfo.UseShellExecute = true;
        proc.Start();
    }

    public void QuitGame()
    {
        Application.Quit();
    }

}
