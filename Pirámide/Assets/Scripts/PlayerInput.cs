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

        if(Input.GetButtonDown("Jump") && player.canJump)
        {
            player.Jump();
        }
    }
}
