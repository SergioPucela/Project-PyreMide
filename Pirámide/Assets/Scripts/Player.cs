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
    public float jumpForce = 20;

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
            print(canJump);
        }
        else
        {
            canJump = false;
            Debug.DrawRay(transform.position - new Vector3(0, sprite.bounds.extents.y + spriteOffSet, 0), down * hitDistance, Color.blue);
            print(canJump);
        }

        return canJump;
    }


    public void Jump()
    {
        rb2D.AddForce(Vector2.up * jumpForce);
    }

}
