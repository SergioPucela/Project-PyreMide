using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    bool modoVista = false;
    public Rotacion jugador;
    public RotacionCamara camara;

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        if (Input.GetKeyDown("v"))
        {
            if (modoVista)
            {
                camara.enabled = true;
                jugador.enabled = false;
                modoVista = !modoVista;
            }
            else
            {
                jugador.enabled = true;
                camara.enabled = false;
                modoVista = !modoVista;
            }
        }
    }
}
