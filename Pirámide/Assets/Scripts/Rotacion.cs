using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotacion : MonoBehaviour
{

    float destinoRotacion = 0;
    public float tiempoRotacion = 1;
    Sequence mySequence = DOTween.Sequence();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            destinoRotacion = transform.rotation.eulerAngles.y;
            mySequence.Append(transform.DORotate(new Vector3(0,destinoRotacion + 90,0), tiempoRotacion, RotateMode.FastBeyond360));
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            destinoRotacion = transform.rotation.eulerAngles.y;
            transform.DORotate(new Vector3(0, destinoRotacion -90, 0), tiempoRotacion, RotateMode.FastBeyond360);
        }
    }
}
