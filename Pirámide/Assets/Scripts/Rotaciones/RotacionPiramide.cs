using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotacionPiramide : Rotacion
{
    GameObject oppositeFace;
    public GameObject[] facesFLBR;
    int actualIndex = 0;
    void Start()
    {
        oppositeFace = facesFLBR[0];
        oppositeFace.SetActive(false);
    }

    void Update()
    {

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
                ChangeOppositeFace(right);
            }

        }

        else
        {
            if (myTween == null || myTween.IsActive() == false)
            {
                destinoRotacion = transform.rotation.eulerAngles.y;
                myTween = (transform.DORotate(new Vector3(0, destinoRotacion - 90, 0), tiempoRotacion, RotateMode.FastBeyond360));
                myTween.Play();
                ChangeOppositeFace(right);
            }
        }
    }

    public void ChangeOppositeFace(bool right)
    {
        oppositeFace.SetActive(true);
        if (right)
        {
            if (actualIndex == 3)
                actualIndex = 0;
            else
                actualIndex++;
        }
        else
        {
            if (actualIndex == 0)
                actualIndex = 3;
            else
                actualIndex--;
        }
        oppositeFace = facesFLBR[actualIndex];
        oppositeFace.SetActive(false);
    }

    public GameObject GetOppositeFace()
    {
        return oppositeFace;
    }


}
