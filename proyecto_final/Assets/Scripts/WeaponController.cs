using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour
{
    [Header("General")]
    public LayerMask hittableLayers;
    public GameObject bulletHolePrefab;

    [Header("Shoot Paramaters")]
    public float FireRange = 200;
    public float force = 4;

    public Transform cameraPlayerTransform;

    //private void Start()
    //{
        //cameraPlayerTransform = GameObject.FindGameObjectWithTag("MainCamera").transform;
    //}

    private void Update()
    {
        HandleShoot();

    }

    /*private void HandleShoot()
    {
        if (Input.GetButtonDown("Jump"))
        {
            RaycastHit hit; //Guarda todos los datos una vez que el raycast golpea algun objeto

            //Physics raycast devuelve un boolean una vez que golpee un objeto
            //1mer parametro desde donde va a salir el laser
            //2do parametro direccion donde quiera que salga
            //3er parametro donde quiero que se guarde la inf una vez que toca al objeto
            //4to parametro cuanta distancia queremos que recorra el laser
            //5to parametro que capas quiero que afecte
            if(Physics.Raycast(cameraPlayerTransform.position, cameraPlayerTransform.forward, out hit, FireRange, hittableLayers))
            {
                
                GameObject bulletHoleClone = Instantiate(bulletHolePrefab, hit.point + hit.normal * 0.001f, Quaternion.LookRotation(hit.normal));
                Destroy(bulletHoleClone, 4f);
                //Debug.DrawRay(cameraPlayerTransform.position, cameraPlayerTransform.forward * FireRange, Color.green);

                if (hit.collider.GetComponent<Rigidbody>() != null)
                {
                    hit.collider.GetComponent<Rigidbody>().AddForce(hit.normal * force);
                    //Debug.DrawRay(cameraPlayerTransform.position, Vector3.forward * 10f, Color.red);
                }
            }
           

        }
    }*/

    private void HandleShoot()
    {
        if (Input.GetButtonDown("Jump"))
        {
            RaycastHit hit; //Guarda todos los datos una vez que el raycast golpea algun objeto

            //Physics raycast devuelve un boolean una vez que golpee un objeto
            //1mer parametro desde donde va a salir el laser
            //2do parametro direccion donde quiera que salga
            //3er parametro donde quiero que se guarde la inf una vez que toca al objeto
            //4to parametro cuanta distancia queremos que recorra el laser
            //5to parametro que capas quiero que afecte
            if(Physics.Raycast(cameraPlayerTransform.position, cameraPlayerTransform.forward, out hit, FireRange, hittableLayers))
            {
                if (hit.transform.CompareTag("Enemigo"))
                {
                    GameObject bulletHoleClone = Instantiate(bulletHolePrefab, hit.point + hit.normal * 0.001f, Quaternion.LookRotation(hit.normal));
                    Destroy(bulletHoleClone, 4f);
                    Debug.Log("Enemigo");
                    //Debug.DrawRay(cameraPlayerTransform.position, cameraPlayerTransform.forward * FireRange, Color.green);
                    hit.transform.GetComponent<Enemigo>().Muerte();
                    if (hit.collider.GetComponent<Rigidbody>() != null)
                    {
                        hit.collider.GetComponent<Rigidbody>().AddForce(hit.normal * force);
                        //Debug.DrawRay(cameraPlayerTransform.position, Vector3.forward * 10f, Color.red);
                    }

                }
                
            } 

        }
    }



    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(cameraPlayerTransform.position, cameraPlayerTransform.forward * FireRange);
    }
}
