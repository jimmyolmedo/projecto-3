using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadLevel : MonoBehaviour
{

    private static bool created;

    public AudioSource audioSource;

    private void Start()
    {
        if (created)
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
        created = true;
    }

    // Update is called once per frame
    void Update()
    {

        Scene activeScene = SceneManager.GetActiveScene();
        string scene = activeScene.name;

        if(scene == "menu" || scene == "game over")
        {
            audioSource.enabled = false;
        }
        else
        {
            audioSource.enabled = true;
        }

    }


}
