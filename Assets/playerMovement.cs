using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float moveSpeed;
    public float jumpForce;
    private Rigidbody2D rb;

    public bool isGrounded;
    public Transform groundCheck;
    public float checkedRadius;
    public LayerMask whatIsGround;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkedRadius, whatIsGround);
    }

    //IF PLAYERS PRESS A OR LEFT ARROW, THE MOVE RIGHT! IF PLAYERS PRESS D AND RIGHT ARROW THEY GO LEFT!
    void Movement()
    {
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);
        }

        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            rb.velocity = new Vector2(moveSpeed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

        if (isGrounded == true) //iF GROUNDED IS EQUAL TO TRUE THEN PLAYERS CAN JUMP!
        {
            if ((Input.GetKeyDown(KeyCode.W)) || Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = Vector2.up * jumpForce;
            }
        }
    }
}
