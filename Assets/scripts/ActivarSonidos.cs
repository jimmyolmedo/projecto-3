using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ActivarSonidos : MonoBehaviour
{
    [Header("Eventos")]
    public UnityEvent OnPress;
    public UnityEvent Ontrigger;
    public UnityEvent oncollision;

    public AudioSource audioSource;



    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            OnPress.Invoke();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        oncollision.Invoke();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Ontrigger.Invoke();
    }


    public void CambioSonido(AudioClip clip)
    {
        audioSource.clip = clip;
    }

}
