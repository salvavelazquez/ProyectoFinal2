using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour

{
    [SerializeField]
    private float velocidadXAleatoria;
    private float daño = 3;

    void Start()
    {
        Destroy(gameObject, 1f); // Destruye la bala
    }

    private void Update()
    {
        velocidadXAleatoria = Random.Range(30, 40); // asigna un valor random entre 30 y 40
        transform.Translate(velocidadXAleatoria * Time.deltaTime, 0, 0); // se aplica el movimiento de la bala
    }

    private void OnCollisionEnter(Collision collision)
    {
        VidaPlayer dañovida = GameObject.Find("Player").GetComponent<VidaPlayer>(); // se crea un componente "dañovida" para poder hacer daño al jugador.
        if (collision.gameObject.CompareTag("Player")) // un if para cuando se detecte la colisión 
        {
            dañovida.vida =- daño ; // cuando detecta la colision la vida del jugador será reducida
            Destroy(gameObject); // destruye el objeto
        }
    }
    
}
