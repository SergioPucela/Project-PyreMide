using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class RotacionCamara : MonoBehaviour
{

    float destinoRotacion = 0;
    public float tiempoRotacion = 1;
    Tween myTween;

    public Transform camara;
    public SpriteRenderer player_render;

    void Awake()
    {
        GameObject player = GameObject.FindWithTag("Player");

        if (player != null)
            player_render = player.GetComponent<SpriteRenderer>();
    }

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

        if (camara.rotation.y > 45 || camara.rotation.y < -45)
            player_render.enabled = false;
        else
            player_render.enabled = true;
    }
}
