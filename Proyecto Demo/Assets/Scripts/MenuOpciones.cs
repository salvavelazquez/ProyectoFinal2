using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    public int numeroEscena;
    public void Jugar()
    {
        SceneManager.LoadScene(numeroEscena);

    }

    public void Salir()
    {
        Application.Quit();

    }
}
