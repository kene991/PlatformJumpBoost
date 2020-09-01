using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerJumpBoost : MonoBehaviour
{

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
     if (collision.gameObject.CompareTag("Green")) //If player jumps on the Green platform they increase the y axis velcity by 4
        {
            rb.velocity = Vector2.up * 4;
        }

     if (collision.gameObject.CompareTag("Yellow")) //If player jumps on the Green platform they increase the y axis velcity by 8
        {
            rb.velocity = Vector2.up * 8;
        }

     if (collision.gameObject.CompareTag("Red")) //If player jumps on the Green platform they increase the y axis velcity by 12
        {
            rb.velocity = Vector2.up * 12;
        }
    }
}
