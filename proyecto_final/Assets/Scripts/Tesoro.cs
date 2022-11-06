using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Tesoro : MonoBehaviour
{
    public GameObject ObjPuntos;
    public AudioSource quienEmite;
    public AudioClip sonidoTesoro;
    public float volumen=1f;


    private void OnTriggerEnter(Collider other) 
     {
        if (other.tag =="Player")
        {
           //sumo un tesoro y se destruye
            ObjPuntos.GetComponent<TesorosAgarrados>().tesoros +=1;
            AudioSource.PlayClipAtPoint(sonidoTesoro,gameObject.transform.position);
            Destroy(gameObject);
        }
        
     }
}
