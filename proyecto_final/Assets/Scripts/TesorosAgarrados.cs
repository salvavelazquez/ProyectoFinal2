using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class TesorosAgarrados : MonoBehaviour
{
   public int tesoros;
   public Text textoTesoros;

   public GameObject Submarino;
   public GameObject camSubmarino;
   public GameObject camMain;

   private bool activo=true;
   private float speed = 2f;
   private float limiteY = -5;
   private bool estado = true;


    private void Update() 
   {
        textoTesoros.text = "Tesoros: " + tesoros.ToString() + "/5";
        if (tesoros == 5 && activo ==true)
        {
          Submarino.transform.Translate(0, speed * Time.deltaTime,0);
            if (estado)
            {
                Camera.main.gameObject.SetActive(false);
                camSubmarino.SetActive(true);
                estado = false;
            }
        }
        if (Submarino.transform.position.y > limiteY && activo == true)
        {
            activo = false;
            Submarino.transform.position = new Vector3 (1, limiteY, -280);
            camSubmarino.SetActive(false);
            camMain.SetActive(true);
        }
   }
    
}
