using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderEnemyShoot : MonoBehaviour
{
    [SerializeField]
    private GameObject disparo;
    [SerializeField]
    private float tiempoAleatorio;
    void Start()
    {
        Invoke("GenerarDisparo", tiempoAleatorio);
    }

    public void GenerarDisparo()
    {
        Instantiate(disparo, transform.position, transform.rotation);
        tiempoAleatorio = Random.Range(2, 5);
        Invoke("GenerarDisparo", tiempoAleatorio);
    }

}
