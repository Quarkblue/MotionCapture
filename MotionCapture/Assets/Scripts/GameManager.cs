using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Python.Runtime;
using System;
using System.IO;
using Unity.VisualScripting;

public class GameManager : MonoBehaviour
{
    //dynamic MoCapModule;

    public bool StartRecieving = true;
    public static GameManager Instance;
    public bool stopRecieving = false;

    private void OnEnable()
    {
        //Runtime.PythonDLL = Application.dataPath + "/StreamingAssets/Python-3.7.9/python37.dll";
        //PythonEngine.Initialize();
    }

    //Start is called before the first frame update
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(this);
        }


        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnDisable()
    {
        stopRecieving = true;
    }

}
