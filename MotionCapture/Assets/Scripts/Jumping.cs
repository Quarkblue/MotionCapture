using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumping : MonoBehaviour
{

    public float speed = 10f;
    public Rigidbody rb;
    private bool isJumping;
    public bool comingDown = false;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();    
        rb = GetComponent<Rigidbody>();
        isJumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isJumping == false)
        {
            animator.SetBool("isJumping", true);
            rb.velocity = new Vector3(0, 5, 0);
            isJumping = true;
        }
        else
        {
            animator.SetBool("isJumping", false);
            isJumping = false;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        isJumping = false;
    }
}
