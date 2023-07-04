using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portales : MonoBehaviour
{
    [Header("mover al jugador")]
    public Transform teleportPos;
    public bool girar;


    [Header("verificar el color del jugador")]
    public bool rojo;
    public bool azul;
    public bool activar;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VerificarColor();
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player") && activar == true)
        {
            collision.gameObject.transform.position = teleportPos.position;

            if (girar)
            {
                collision.gameObject.GetComponent<Player>().girar();
            }
        }
    }


    public void VerificarColor()
    {
        if (azul)
        {
            if(GameObject.Find("Player").GetComponent<Player>().azul == true)
            {
                activar = true;
            }
            else
            {
                activar = false;
            }
        }

        if (rojo)
        {
            if (GameObject.Find("Player").GetComponent<Player>().azul == false)
            {
                activar = true;
            }
            else
            {
                activar = false;
            }
        }

    }


}
