using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    [SerializeField]
    private float vida;


    public void TomarDanio(float danio)
    { // un if para que cuando la vida del enemigo llegue a 0 se active la funcion Muerte
        vida -= danio;
        if(vida <= 0)
        {
            Muerte();
        }
    }

       public void Muerte()
    {
        //Instantiate(efectoMuerte, transform.position, Quaternion.identity);
        Destroy(gameObject,2f); // destruye el enemigo
    }
}
