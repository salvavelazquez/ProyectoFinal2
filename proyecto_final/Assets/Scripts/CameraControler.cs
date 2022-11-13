using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour
{
    public float speedV;

    float pitch;

    void Start()
    {
        
    }

    
    void Update()
    {
        pitch -= speedV * Input.GetAxis("Mouse Y");

        transform.eulerAngles = new Vector3(pitch, 0.0f , 0.0f);
    }
}
