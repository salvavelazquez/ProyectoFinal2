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
   private bool activo=true;
   private float speed = 2f;
   private float limiteY = -5; 

   private void Update() 
   {
        textoTesoros.text = "Tesoros: " + tesoros.ToString() + "/5";
        if (tesoros ==5 && activo ==true)
        {
          Submarino.transform.Translate(0, speed * Time.deltaTime,0);
        }
        if (Submarino.transform.position.y > limiteY)
        {
           Submarino.transform.position = new Vector3 (1, limiteY, -280);
        }
   }
    
}
