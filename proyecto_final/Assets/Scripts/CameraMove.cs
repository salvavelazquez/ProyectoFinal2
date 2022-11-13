using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
   public Vector3 offset;
    private Transform target;
    [Range(0, 1)] public float lerpValue;
    public float sensibilidad;

    void Start()
    {
        target = GameObject.Find("NewPlayer").transform; 
    }

    //Se ejecuta al final de todo
    private void LateUpdate()
    {
        //mueve la posicion de un objeto hasta otro vector, de manera suavisada.
        transform.position = Vector3.Lerp(transform.position, target.position + offset, lerpValue);
        offset = Quaternion.AngleAxis(Input.GetAxis("Mouse X")* sensibilidad, Vector3.up) * offset; //AngleAxis: Gira algo con respecto a un eje;
        transform.LookAt(target);
    }
}
