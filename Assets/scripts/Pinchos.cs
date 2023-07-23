using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pinchos : MonoBehaviour
{

    public bool azul;
    public bool Activado;


    public SpriteRenderer sp;

    public Sprite rojoSp;
    public Sprite azulSp;


    // Start is called before the first frame update
    void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (azul)
        {
            sp.sprite = azulSp;
        }
        else
        {
            sp.sprite = rojoSp;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (azul == true)
            {
                if(GameObject.Find("Player").GetComponent<Player>().azul == false)
                {
                    GameObject.Find("SceneManager").GetComponent<CambioScenas>().YouLose();
                    Destroy(collision.gameObject);
                }
                else
                {
                    GameObject.Find("Player").GetComponent<Player>().EncenderParticulas();

                    //encender particulas
                }
            }
            if (azul == false)
            {
                if (GameObject.Find("Player").GetComponent<Player>().azul == true)
                {
                    GameObject.Find("SceneManager").GetComponent<CambioScenas>().YouLose();
                    Destroy(collision.gameObject);
                }
                else
                {
                    GameObject.Find("Player").GetComponent<Player>().EncenderParticulas();


                    //encender particulas
                }
            }
        }
    }


    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameObject.Find("Player").GetComponent<Player>().ApagarParticulas();
        }
    }

}
