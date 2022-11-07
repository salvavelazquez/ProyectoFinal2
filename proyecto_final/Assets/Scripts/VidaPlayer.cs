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
        vida = Mathf.Clamp(vida, 0, 100);
        //es el fillamount que va disminuyendo
        barradevida.fillAmount = vida / 100;

        if (vida <= 0)
        {
            //hace que el tiempo sea 0 yllama a game over
            Time.timeScale = 0f;
            GameOverManager.gameOverManager.CallGameOver();

        }
        else
        {
            //si no es 0, hace que el tiempo sea 1
            Time.timeScale = 1f;
        }
    }
   
}