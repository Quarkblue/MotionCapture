using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundary : MonoBehaviour
{
    public static float leftSide = -2f ;
    public static float rightSide = 2f;
    public float internalleft;
    public float internalRight;
    void Update()
    {
        internalleft = leftSide;
        internalRight = rightSide;
    }
}
