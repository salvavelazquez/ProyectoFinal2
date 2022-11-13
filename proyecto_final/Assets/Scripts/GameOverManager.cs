using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   
public class GameOverManager : MonoBehaviour
{
    public GameObject GameOver;
    //hace que el script game over sea un script static y este fuera de la escena 
    public static GameOverManager gameOverManager;
    // Start is called before the first frame update
    void Start()
    {
        gameOverManager = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CallGameOver()
        {
            //activa o desactiva el gameover y llama a gameover
            GameOver.SetActive(true);
            // Cursor.lockState = CursorLockMode.None;
        }
}
