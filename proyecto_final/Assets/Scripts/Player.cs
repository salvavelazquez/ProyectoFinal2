using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 15f;
    public float horizontalInput;
    public float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        UpdateMovement();
    }

    private void UpdateMovement()
    {
        //Configuracion de movimiento horizontal y vertical
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Jump");
        transform.Rotate(new Vector3(0f, Input.GetAxis("Horizontal") * 50f, 0f) * Time.deltaTime);
        transform.Rotate(new Vector3(Input.GetAxis("Vertical") * -50f, 0f, 0f) * Time.deltaTime);

        transform.Translate(Input.GetAxis("Horizontal") * speed * Time.deltaTime, 0, 0);
        //Movimiento del tiburon hacia adelante
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);


    }
}
