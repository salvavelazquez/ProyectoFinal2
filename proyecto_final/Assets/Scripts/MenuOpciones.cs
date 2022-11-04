using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuOpciones : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene("Main");

    }

    public void Salir()
    {
        Application.Quit();

    }
}
