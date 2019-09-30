using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerRenderer : MonoBehaviour
{

    public float rotationAngleRender = 45f;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.rotation.eulerAngles.y > rotationAngleRender || transform.rotation.eulerAngles.y < -rotationAngleRender)
        {
            player.GetComponent<SpriteRenderer>().enabled = false;
        }
        else
            player.GetComponent<SpriteRenderer>().enabled = true;
    }
}
