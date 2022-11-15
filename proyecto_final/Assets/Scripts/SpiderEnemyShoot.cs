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
        Invoke(nameof(GenerarDisparo), tiempoAleatorio); // se invoca un disparo al inicio
    }

    public void GenerarDisparo()
    {
        Instantiate(disparo, transform.position, transform.rotation); // se instancia el disparo
        tiempoAleatorio = Random.Range(2, 5); // se establece un tiempo entre disparos
        Invoke(nameof(GenerarDisparo), tiempoAleatorio); // se invoca un disparo cada X cantidad de tiempo
    }

}
