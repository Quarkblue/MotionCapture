using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Python.Runtime;
using System;
using System.IO;

public class GameManager : MonoBehaviour
{
    dynamic MoCap;

    private void OnEnable()
    {
        Runtime.PythonDLL = Application.dataPath + "/StreamingAssets/Python-3.7.9/python37.dll";
        PythonEngine.Initialize();
    }

    //Start is called before the first frame update
    void Start()
    {
        using (Py.GIL())
        {
            using PyScope scope = Py.CreateScope();
            MoCap = PyModule.FromString("SingleTakeClassification", File.ReadAllText(Application.dataPath + "/StreamingAssets/PythonScripts/MoCap.py"));
            scope.Exec(MoCap.SingleTakeClassification());
            string position = scope.Get<string>("position");
            Debug.Log(position);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
