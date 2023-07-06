using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("cambiar el color del personaje")]
    public SpriteRenderer sP;
    public Sprite spriteRojo;
    public Sprite spriteAzul;
    public bool azul = true;

    [Header("movimiento")]
    public float speed;

    [Header("rotacion")]
    public bool girado;

    [Header("Salto")]
    public Rigidbody2D Rb; 

    // Start is called before the first frame update
    void Start()
    {
        sP = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        movement();

        ActualColor();

    }


    public void CambioColor()
    {
        if(azul == true)
        {
            azul = false;
            sP.sprite = spriteRojo;
        }
        else
        {
            azul = true;
            sP.sprite = spriteAzul;
        }
    }


    public void movement()
    {

        transform.position += new Vector3(speed * Time.deltaTime, 0);


        //definir la rotacion del personaje

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Cambio"))
        {
            CambioColor();
            Destroy(collision.gameObject);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Pared"))
        {
            girar();
        }
        if (collision.gameObject.CompareTag("plataforma"))
        {
            transform.parent = collision.transform;
        }
    }


    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plataforma"))
        {
            transform.parent = null;
        }
    }



    public void girar()
    {
        transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y);

        speed *= -1;

    }


    public void ActualColor()
    {
        if (azul == true)
        {
            sP.sprite = spriteAzul;
        }
        else
        {
            sP.sprite = spriteRojo;
        }
    }



    public void Salto(float _salto)
    {

    }


}
