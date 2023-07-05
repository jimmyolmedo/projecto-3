using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{

    public bool Azul;

    public bool Activado;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Activar();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && Activado == true)
        {
            Debug.Log("ganaste");
        }
    }


    public void Activar()
    {
        if (Azul)
        {
            if(GameObject.Find("Player").GetComponent<Player>().azul == true)
            {
                Activado  = true;
            }
        }
        else if (!Azul)
        {
            if (GameObject.Find("Player").GetComponent<Player>().azul == false)
            {
                Activado = true;
            }
        }
        else
        {
            Activado = false;
        }
    }

}
