using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float vida;


    public void TomarDanio(float danio)
    {
        vida -= danio;
        if(vida <= 0)
        {
            Muerte();
        }
    }

       public void Muerte()
    {
        //Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject,2f);
    }
}
