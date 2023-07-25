using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioScenas : MonoBehaviour
{

    public GameObject youLose;

    public GameObject youWin;

    [Header("crear particulas en la posicion del jugador")]
    public Transform playerPos;

    public bool azul;

    public GameObject partAzul;
    public GameObject partRoja;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        playerPos.position = GameObject.Find("Player").transform.position;

        azul = GameObject.Find("Player").GetComponent<Player>().azul;
    }


    public void YouLose()
    {

        StartCoroutine(Derrota());


        /*
        Time.timeScale = 0;

        youLose.SetActive(true);

        */
    }


    public void Reload()
    {
        Scene activeScene = SceneManager.GetActiveScene();

        string scene = activeScene.name;

        Time.timeScale = 1;

        SceneManager.LoadScene(scene);
    }


    public void YouWin()
    {
        Time.timeScale = 0;

        youWin.SetActive(true);
    }


    public void NextLevel(string _nivel)
    {
        Time.timeScale = 1;

        SceneManager.LoadScene(_nivel);
    }

    public IEnumerator Derrota()
    {

        if(azul == true)
        {
            Instantiate(partAzul, playerPos.position, Quaternion.identity);
        }
        else
        {
            Instantiate(partRoja, playerPos.position, Quaternion.identity);
        }

        yield return new WaitForSeconds(2);

        Reload();


    }

}
