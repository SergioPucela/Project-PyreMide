using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPlayerRenderer : MonoBehaviour
{

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
        if (camara.rotation.y > 45 || camara.rotation.y < -45)
            player_render.enabled = false;
        else
            player_render.enabled = true;
    }
}
