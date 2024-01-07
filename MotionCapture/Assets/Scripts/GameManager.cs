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
    public string movement;
    public string prevMove;


    private void OnEnable()
    {
        EventManager.OnRightBend += MoveRight;
        EventManager.OnLeftBend += MoveLeft;
        EventManager.OnCenterBend += MoveCenter;

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

        prevMove = "";
        
    }

    // Update is called once per frame
    void Update()
    {
        if(movement == "Center" && movement != prevMove)
        {
            EventManager.CenterBendEvent();
        }else if(movement == "Left" && movement != prevMove)
        {
            EventManager.LeftBendEvent();
        }else if(movement == "Right" && movement != prevMove)
        {
            EventManager.RightBendEvent();
        }
    }


    private void OnDisable()
    {
        stopRecieving = true;
        EventManager.OnRightBend -= MoveRight;
        EventManager.OnLeftBend -= MoveLeft;
        EventManager.OnCenterBend -= MoveCenter;
    }


    private void MoveLeft()
    {
        Debug.Log("Moving left");
        prevMove = "Left";
    }

    private void MoveRight()
    {
        Debug.Log("Moving right");
        prevMove = "Right";
    }

    private void MoveCenter()
    {
        Debug.Log("Moving center");
        prevMove = "Center";
    }



}
