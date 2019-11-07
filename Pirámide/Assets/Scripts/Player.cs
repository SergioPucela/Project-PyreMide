using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb2D;
    public float jumpForce = 20f;
    public float movementSpeed = 10f;

    public bool canJump;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        canJump = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        rb2D.velocity = new Vector2(0, rb2D.velocity.y);
    }

    public void Jump()
    {
        rb2D.velocity = Vector2.up * jumpForce;
    }

    public void Move(bool right)
    {
        if (right)
        {
            rb2D.velocity = new Vector2(movementSpeed * Time.fixedDeltaTime, rb2D.velocity.y) ;
        }
        else
        {
            rb2D.velocity = new Vector2(-movementSpeed * Time.fixedDeltaTime, rb2D.velocity.y);
        }
    }

}
