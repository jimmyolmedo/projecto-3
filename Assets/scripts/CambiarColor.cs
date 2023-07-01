using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarColor : MonoBehaviour
{

    [Header("cambiar colores")]
    public bool rojo;
    public bool azul;
    public GameObject luzRoja;
    public GameObject luzAzul;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        ColorActual();


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


    public void ColorActual()
    {
        if(azul == true)
        {
            luzAzul.SetActive(true);
            luzRoja.SetActive(false);
        }
        else
        {
            luzRoja.SetActive(true);
            luzAzul.SetActive(false);
        }
    }


}
