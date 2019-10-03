using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    public Rotacion rotacionPiramide;
    public Rotacion rotacionCamara;

    // Update is called once per frame
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
                rotacionPiramide.Rotate(true);
            else
                rotacionCamara.Rotate(true);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (rotacionPiramide.enabled)
                rotacionPiramide.Rotate(false);
            else
                rotacionCamara.Rotate(false);
        }
    }
}
