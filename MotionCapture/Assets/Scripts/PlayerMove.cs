using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 3f;
    public float laneWidth = 3f;

    private int currentLane = 1;

    void Update()
    {

        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);


        if (Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.LeftArrow))
            ShiftLane(-1);

        else if (Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.RightArrow))
            ShiftLane(1);
    }

    void ShiftLane(int direction)
    {
        int newLane = Mathf.Clamp(currentLane + direction, 0, 2);
        float targetX = newLane * laneWidth;
        transform.position = new Vector3(targetX, transform.position.y, transform.position.z);
        currentLane = newLane;
    }
}
