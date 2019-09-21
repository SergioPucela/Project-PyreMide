using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotacion : MonoBehaviour
{

    float destinoRotacion = 0;
    public float tiempoRotacion = 1;
    Tween myTween;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            if (myTween == null || myTween.IsActive() == false)
            {
                destinoRotacion = transform.rotation.eulerAngles.y;
                myTween = (transform.DORotate(new Vector3(0, destinoRotacion + 90, 0), tiempoRotacion, RotateMode.FastBeyond360));
                myTween.Play();
            }

        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
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
