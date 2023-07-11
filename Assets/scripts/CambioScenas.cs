using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScenas : MonoBehaviour
{

    public GameObject youLose;

    public GameObject youWin;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void YouLose()
    {
        Time.timeScale = 0;

        youLose.SetActive(true);

    }


    public void Reload()
    {
        Scene activeScene = SceneManager.GetActiveScene();

        string scene = activeScene.name;

        Time.timeScale = 1;

        SceneManager.LoadScene(scene);
    }

}
