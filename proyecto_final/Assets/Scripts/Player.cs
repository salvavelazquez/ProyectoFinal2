using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speedV;
    [SerializeField]
    float speed = 3f;
    float rotationSpeed = 5f;
    float pitch;
    
    void Update()
    {

      float horizontalInput = Input.GetAxis("Horizontal");
      float verticalInput = Input.GetAxis("Vertical");

      Vector3 movementDirection = new Vector3(horizontalInput, 0, verticalInput);

      transform.position = transform.position + movementDirection * speed * Time.deltaTime;
      // transform.Translate(movementDirectionspeedTime.deltaTime);

      transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(movementDirection),rotationSpeed*Time.deltaTime);
      
     //pitch -= speedV * Input.GetAxis("Mouse Y");

     //transform.eulerAngles = new Vector3(pitch, 0.0f , 0.0f);
    }

}
