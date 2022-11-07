using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour

{
    [SerializeField]
    private float velocidadXAleatoria;

    void Start()
    {
        Destroy(gameObject, 1.3f);
    }

    private void Update()
    {
        velocidadXAleatoria = Random.Range(30, 40);
        transform.Translate(velocidadXAleatoria * Time.deltaTime, 0, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
