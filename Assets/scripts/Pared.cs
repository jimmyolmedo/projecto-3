using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pared : MonoBehaviour
{
    [Header("cambiar posicion")]
    public Vector3 posAzul;
    public Vector3 posRojo;
    public float speed;

    [Header("color actual")]
    public GameObject luzAzul;
    public GameObject luzRojo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        posPared();

        ColorActual();

    }


    public void posPared()
    {
        if(GameObject.Find("Player").GetComponent<CambiarColor>().azul == true)
        {
            if(transform.position != posAzul)
            {
                transform.position = Vector3.MoveTowards(transform.position, posAzul, speed);
            }
        }
        else
        {
            if (transform.position != posRojo)
            {
                transform.position = Vector3.MoveTowards(transform.position, posRojo, speed);
            }
        }
    }


    public void ColorActual()
    {
        if(GameObject.Find("Player").GetComponent<CambiarColor>().azul == true)
        {
            luzAzul.SetActive(true);
            luzRojo.SetActive(false);
        }
        else
        {
            luzAzul.SetActive(false);
            luzRojo.SetActive(true);
        }
    }

}
