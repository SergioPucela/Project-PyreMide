using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotacion : MonoBehaviour
{

    protected float destinoRotacion = 0;
    protected float tiempoRotacion = 0.5f;
    protected Tween myTween;

    public void Rotate(bool right)
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
}
