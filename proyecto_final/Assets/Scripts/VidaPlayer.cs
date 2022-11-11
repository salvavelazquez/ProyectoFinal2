using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VidaPlayer : MonoBehaviour
{
    public float vida = 100;
    public Image barradevida;

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        //la variable vida no va a disminuir mas de 0 y excede a mas de 100
        vida = Mathf.Clamp(vida, 0, 100);
        //si tenemos 90/100 va a hacer 9 para que funcione el fillamount
        barradevida.fillAmount = vida / 100;

        if (vida <= 0)
        {
            //hace que el player se detenga yllama a game over
            Time.timeScale = 0f;
            GameOverManager.gameOverManager.CallGameOver();

        }
        else
        {
            //si no es 0 el player se podra mover 
            Time.timeScale = 1f;
        }
    }
   
}