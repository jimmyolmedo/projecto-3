using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [Header("cambiar el color del personaje")]
    public SpriteRenderer sP;
    public Sprite spriteRojo;
    public Sprite spriteAzul;
    public bool azul = true;
    public string nombreCambiador;


    [Header("movimiento")]
    public float speed;

    [Header("rotacion")]
    public bool girado;

    [Header("Salto")]
    public Rigidbody2D Rb;


    [Header("cambiar nivel")]
    public GameObject youLose;


    [Header("Particulas")]
    public GameObject partAzul;
    public GameObject partRoja;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        movement();

        ActualColor();

    }


    public void CambioColor()
    {
        if(nombreCambiador == "cambiadorRojo")
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
            nombreCambiador = collision.name;
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

    public void EncenderParticulas()
    {
        if (azul == true)
        {
            partAzul.SetActive(true);
            partRoja.SetActive(false);
        }
        else
        {
            partAzul.SetActive(false);
            partRoja.SetActive(true);
        }
    }


    public void ApagarParticulas()
    {
        partAzul.SetActive(false);
        partRoja.SetActive(false);
    }


    public void CambiarEscena()
    {
        Time.timeScale = 1;

        Scene activeScene = SceneManager.GetActiveScene();
        string escena = activeScene.name;
        SceneManager.LoadScene(escena);
    }

}
