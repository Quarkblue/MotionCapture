using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Load_scene : MonoBehaviour
{
    // Start is called before the first frame update
    public void Lvl1()
    {
        
        SceneManager.LoadScene("Game");
        Debug.Log("sceneswitch");
    }
}
