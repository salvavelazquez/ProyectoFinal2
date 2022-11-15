using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderMelee : MonoBehaviour
{
    public int rutina; // rutinas del enemigo
    public float tiempo; // cronometro para el tiempo entre rutinas
    public Quaternion angulo; // se usa para rotar al enemigo
    public float grado; // para detectar el grado del angulo
    public GameObject target; // se estable en target del enemigo (seria el jugador)
    private float daño = 10; // la cantidad de daño que hara al atacar
    void Start()
    {
        target = GameObject.Find("Player"); // se establece al GameObjecto con etiqueta player como target
    }

    public void ComportamientoEnemigo()
    {
        if (Vector3.Distance(transform.position, target.transform.position) > 5) // si el jugador esta a una distancia mayor a 5 entonces hará las siguientes rutinas
        {
            tiempo += 1 * Time.deltaTime; // tiempo sumando tiempo
            if (tiempo >= 4) // if para cuando el tiempo llegue a 4
            {
                rutina = Random.Range(0, 1); // rutinas "aleatorias"
                tiempo = 0; // se resetea el tiempo
            }
            switch (rutina) // un switch para las rutinas
            {
                case 0:
                    grado = Random.Range(0, 360); // rota x cantidad de grados
                    angulo = Quaternion.Euler(0, grado, 0);
                    rutina++; // rutina suma +1 para pasar al caso 2
                    break;
                case 1:
                    transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f); // se establece que la rotacion sera igual al angulo establecido
                    transform.Translate(Vector3.forward * 3 * Time.deltaTime); // se moverá hacia adeltane con una velocidad de 1
                    break;
            }
        }
        else
        {
            if (Vector3.Distance(transform.position, target.transform.position) > 2)
            {
                var lookPos = target.transform.position - transform.position; // se crea una var en la cual se resta la posision del target(jugador) con la posicion del enemigo
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos); // se crea una variable para la rotacion
                transform.rotation = Quaternion.RotateTowards(transform.rotation, rotation, 3); // el enemigo rotará segun la variable de ratation con una velocidad de 3
                transform.Translate(Vector3.forward * 5 * Time.deltaTime); // se desplaza hacia adeltante con una velocidad de 2
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        VidaPlayer dañovida = GameObject.Find("Player").GetComponent<VidaPlayer>(); // se crea un componente "dañovida" para poder hacer daño al jugador.
        if (collision.gameObject.CompareTag("Enemigo")) // un if para cuando se detecte la colisión 
        {
            dañovida.vida = -daño; // cuando detecta la colision la vida del jugador será reducida
        }
    }
}
