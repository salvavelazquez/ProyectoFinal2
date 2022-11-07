using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{
  //llama a la escena reinicio
public void CargarEscenaReinicio()
    {
            SceneManager.LoadScene("SampleScene");
    }
     //llama a la escena menu
        public void CargarEscenaMenu()
        {
          SceneManager.LoadScene("Menu");
        }
    }