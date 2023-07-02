using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meta : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.bounds.Contains(transform.position))
        {
            // El objeto está completamente dentro del collider
            Debug.Log("El objeto está completamente dentro del collider");
        }
    }

}
