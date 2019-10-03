using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotacionCamara : Rotacion
{
    public float rotationAngleRenderLeft = 45f;
    public float rotationAngleRenderRight = 45f;
    public GameObject player;
    Quaternion rotationCamera;

    // Update is called once per frame
    void Update()
    {
        RenderPlayer();
    }

    void RenderPlayer()
    {
        if ((transform.rotation.eulerAngles.y > rotationAngleRenderRight && transform.rotation.eulerAngles.y < 180) || (transform.rotation.eulerAngles.y > 180 && transform.rotation.eulerAngles.y < rotationAngleRenderLeft))
            player.GetComponent<SpriteRenderer>().enabled = false;
        else
            player.GetComponent<SpriteRenderer>().enabled = true;
    }

    void OnEnable()
    {
        rotationCamera = transform.rotation;
    }

    private void OnDisable()
    {
        transform.rotation = rotationCamera;
        RenderPlayer();
    }
}

