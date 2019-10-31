using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public RotacionPiramide rotacionPiramide;
    public RotacionCamara rotacionCamara;
    public Player player;

    void Update()
    {
        GetInput();
    }

    void FixedUpdate()
    {
        GetMovementInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown("v"))
        {
            rotacionPiramide.enabled = !rotacionPiramide.enabled;
            rotacionCamara.enabled = !rotacionCamara.enabled;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (rotacionPiramide.enabled)
            {
                rotacionPiramide.Rotate(true);
            }
            else
                rotacionCamara.Rotate(false);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (rotacionPiramide.enabled)
            {
                rotacionPiramide.Rotate(false);
            }
            else
                rotacionCamara.Rotate(true);
        }
    }

    void GetMovementInput()
    {
        if (Input.GetButtonDown("Jump") && player.canJump)
        {
            player.Jump();
        }

        if (Input.GetAxisRaw("Horizontal") == 1)
        {
            player.Move(true);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1)
        {
            player.Move(false);
        }
    }
}
