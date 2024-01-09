using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoringSystem : MonoBehaviour
{
    public int score = 0;

    private void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "veg")
        {
            score++;
            Debug.Log(score);
        }
    }
}
