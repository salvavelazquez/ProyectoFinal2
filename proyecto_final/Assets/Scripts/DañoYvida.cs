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
            currentDamageTime += Time.deltaTime;
            //si sucede la col empieza el conteo hasta llegar al tiempo del damagetime
            if (currentDamageTime > damageTime)
            {
                //aumenta la vida del player y resetea el damage time
                playerVida.vida += cantidad;
                currentDamageTime = 0.0f;
            }
        }
    }
}

