using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{
    public float jumpForce = 5f; // Adjust this value to control the jump height
    public float jumpCooldown = 1f; // Adjust this value to set the jump cooldown time
    private float lastJumpTime;
    private bool isJumping;
    public Animator animator;
    public Rigidbody rb;

    void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        isJumping = false;
        lastJumpTime = 0f;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastJumpTime > jumpCooldown)
        {
            Jump();
        }
    }

    void Jump()
    {
        animator.SetBool("isJumping", true);
        rb.velocity = new Vector3(0, jumpForce, 0);
        isJumping = true;
        lastJumpTime = Time.time;
        Invoke("EndJumpAnimation", 0.5f); // Adjust the delay based on your animation length
    }

    void EndJumpAnimation()
    {
        animator.SetBool("isJumping", false);
    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}
