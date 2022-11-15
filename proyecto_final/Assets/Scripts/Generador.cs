using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour
{
    [SerializeField]
    private GameObject enemigo;
    [SerializeField]
    private float initTime;
    [SerializeField]
    private float repeatTime;

    private int contadorEnemigo;
    void Start()
    {
        InvokeRepeating("GenerateEnemy", initTime, repeatTime);
        InvokeRepeating("Contador", initTime, repeatTime);
    }

    public void Contador()
    {
        contadorEnemigo++;
        if (contadorEnemigo == 6)//cantidad maxima para generar enemigos

        {
            CancelInvoke("GenerateEnemy");
        }
    }
    public void GenerateEnemy()
    {
        Instantiate(enemigo, transform.position, transform.rotation);
    }
}
