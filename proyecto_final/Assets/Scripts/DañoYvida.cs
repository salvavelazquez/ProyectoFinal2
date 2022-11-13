using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DañoYvida : MonoBehaviour
{
    VidaPlayer playerVida;
    //cantidad de daño o vida regenerada
    public int cantidad;
    //tiempo en el cual sucede la accion
    public float damageTime;
    //variable que lleva elconteo del tiempo
    float currentDamageTime;
    // Start is called before the first frame update
    void Start()
    {
        playerVida = GameObject.FindWithTag("Player").GetComponent<VidaPlayer>();       
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Player")
        {
            //el delta time para que el daño sea en segundos y no en cuadro a cuadro y regule el tiempo
            currentDamageTime += Time.deltaTime;
            //si sucede la col empieza el conteo hasta llegar al tiempo del damagetime
            if (currentDamageTime > damageTime)
            {
                //si es positivo aumenta la vida del player y si negativo resta la vida; y resetea el damage time
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
            }
        }
    }
}

