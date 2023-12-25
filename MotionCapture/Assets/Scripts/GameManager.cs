using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Python.Runtime;
using System;

public class GameManager : MonoBehaviour
{

    private void OnEnable()
    {
        Runtime.PythonDLL = Application.dataPath + "/StreamingAssets/Python-3.7.9/python37.dll";
        PythonEngine.Initialize();
    }

    // Start is called before the first frame update
    //void Start()
    //{
    //    using(Py.GIL())
    //    {
    //        using(PyModule scope = Py.CreateScope())
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        
    }
}
