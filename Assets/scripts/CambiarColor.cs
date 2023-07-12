using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{

    [Header("cambiar colores")]
    public bool rojo;
    public bool azul;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        CambioColor();


    }


    public void CambioColor()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (rojo == true)
            {
                rojo = false;
                azul = true;
            }
            else
            {
                azul = false;
                rojo = true;
            }
        }
    }


}
