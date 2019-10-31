using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody2D rb2D;
    Sprite sprite;
    public bool canJump;
    float hitDistance = 0.1f;
    float spriteOffSet = 0.01f;
    public float jumpForce = 20f;
    public float movementSpeed = 10f;

    private void Awake()
    {
        rb2D = GetComponent<Rigidbody2D>();
        sprite = GetComponent<SpriteRenderer>().sprite;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        canJump = GetIsGrounded();
    }

    bool GetIsGrounded()
    {
        Vector2 down = transform.TransformDirection(Vector2.down);

        if(Physics2D.Raycast(transform.position - new Vector3(0, sprite.bounds.extents.y + spriteOffSet, 0), down, hitDistance)) 
        {
            canJump = true;
            Debug.DrawRay(transform.position - new Vector3(0, sprite.bounds.extents.y + spriteOffSet, 0), down * hitDistance, Color.green);
        }
        else
        {
            canJump = false;
            Debug.DrawRay(transform.position - new Vector3(0, sprite.bounds.extents.y + spriteOffSet, 0), down * hitDistance, Color.blue);
        }

        return canJump;
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
