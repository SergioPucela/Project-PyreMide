using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Rotacion : MonoBehaviour
{

    protected float destinoRotacion = 0;
    protected float tiempoRotacion = 0.5f;
    protected Tween myTween;

    virtual public void Rotate(bool right)
    {
        
    }
}
