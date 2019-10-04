using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotacionCamara : Rotacion
{
    public float rotationAngleRenderLeft = 45f;
    public float rotationAngleRenderRight = 45f;
    public GameObject player;
    public RotacionPiramide rotacionPiramide;
    Quaternion rotationCamera;

    // Update is called once per frame
    void Update()
    {
        RenderPlayer();
    }

    public override void Rotate(bool right)
    {
        if (right)
        {
            if (myTween == null || myTween.IsActive() == false)
            {
                destinoRotacion = transform.rotation.eulerAngles.y;
                myTween = (transform.DORotate(new Vector3(0, destinoRotacion + 90, 0), tiempoRotacion, RotateMode.FastBeyond360));
                myTween.Play();
            }

        }

        else
        {
            if (myTween == null || myTween.IsActive() == false)
            {
                destinoRotacion = transform.rotation.eulerAngles.y;
                myTween = (transform.DORotate(new Vector3(0, destinoRotacion - 90, 0), tiempoRotacion, RotateMode.FastBeyond360));
                myTween.Play();
            }
        }
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
        rotacionPiramide.GetOppositeFace().SetActive(true);
    }

    void OnDisable()
    {
        transform.rotation = rotationCamera;
        rotacionPiramide.GetOppositeFace().SetActive(false);
        RenderPlayer();
    }
}

