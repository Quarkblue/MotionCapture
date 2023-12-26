using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Python.Runtime;
using System;
using System.IO;

public class GameManager : MonoBehaviour
{
    dynamic MoCapModule;

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
                //using (PyScope scope = Py.CreateScope())
                //{
                //    MoCap = PyModule.FromString("MoCap", File.ReadAllText(Application.dataPath + "/StreamingAssets/PythonScripts/MoCap.py"));
                //    scope.Exec(MoCap.SingleTakeClassification());
                //    string position = scope.Get<string>("position");
                //    Debug.Log(position);
                //}


//                using (scope)
//                {
//                    MoCapModule = PyModule.FromString("MoCap", File.ReadAllText(Application.dataPath + "/StreamingAssets/PythonScripts/MoCap.py"));

//                    scope.Exec(MoCapModule.SingleTakeClassification());

//                    scope.Exec(@"
//position = 'right'

//def hello():
//    return position
//");
//                    dynamic hello = scope.Get(name: "hello");
//                    Debug.Log(hello());
//                }

                //using PyScope scope = Py.CreateScope();
                //MoCap = PyModule.FromString("MoCap", File.ReadAllText(Application.dataPath + "/StreamingAssets/PythonScripts/MoCap.py"));
                //scope.Exec(MoCap.SingleTakeClassification());
                //string position = scope.Get<string>("position");
                //Debug.Log(position);
            }
        //finally
        //{
        //    PythonEngine.Shutdown();
        //}
    }

    // Update is called once per frame
    void Update()
    {
        
        dynamic MoCapModule = PyModule.FromString("MoCap", File.ReadAllText(Application.dataPath + "/StreamingAssets/PythonScripts/MoCap.py"));
        dynamic position = MoCapModule.videoClassification();

        Debug.Log(position);
    }

    private void OnDisable()
    {
        PythonEngine.Shutdown();
    }

}
