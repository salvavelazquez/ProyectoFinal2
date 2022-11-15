using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
  public float horizontalMove;
    public float verticalMove;
    private Vector3 playerInput;
    public CharacterController player;

    public float playerSpeed;
    private Vector3 movePlayer;
    public float gravity = 9.8f;
    public float fallVelocity; //velocidad de caida

    public Camera mainCamera;
    private Vector3 camForward;
    private Vector3 camRight;

    public Canvas ganaste;
    public GameObject submarino;

    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    void Update()
    {
        horizontalMove = Input.GetAxis("Horizontal");
        verticalMove = Input.GetAxis("Vertical");

        playerInput = new Vector3(horizontalMove, 0, verticalMove);
        //clampMagnitude:cercar la magnitud de la variable, que sea siempre 1 sea la velocidad q tenga, distancia maxima de un valor a otro
        playerInput = Vector3.ClampMagnitude(playerInput, 1);

        camDirection();

        movePlayer = playerInput.x * camRight + playerInput.z * camForward;

        movePlayer = movePlayer * playerSpeed;

        //El Personaje gire hacia la direccion que se esta moviendo.
        player.transform.LookAt(player.transform.position + movePlayer);

        SetGravity();
        player.Move(movePlayer * Time.deltaTime);
    }

    void camDirection()
    {
        camForward = mainCamera.transform.forward;
        camRight = mainCamera.transform.right;

        //no usamos el eje y
        camForward.y = 0;
        camRight.y = 0;

        //Una mira mas ajustada
        camForward = camForward.normalized;
        camRight = camRight.normalized;
    }

    void SetGravity()
    {
        

        //si el jugador esta tocando el suelo
        if (player.isGrounded)
        {
            fallVelocity = -gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
        else
        {
            fallVelocity -= gravity * Time.deltaTime;
            movePlayer.y = fallVelocity;
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Premio")
        {
            submarino.SetActive(true);
            ganaste.gameObject.SetActive(true);
        }
    }
}
