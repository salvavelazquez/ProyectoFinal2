using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    public AudioSource sound;
    public AudioClip soundMenu;
    public int numeroEscena;

    public void Jugar()
    {
        SceneManager.LoadScene(numeroEscena);

    }
    public void SoundButton()
    {
        sound.clip = soundMenu;

        sound.enabled = false;
        sound.enabled = true;
    }
}
