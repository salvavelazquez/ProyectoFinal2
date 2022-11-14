using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private GameObject dialoguePanel;
    [SerializeField] private TMP_Text dialogueText;
    [SerializeField, TextArea(4,6)] private string[] dialogueLines;

    private float typingTime = 0.05f;

    private bool isPlayerInRange;
    private bool didDialogueStart;
    private int lineIndex;
    
    void Update()
    {
        if (isPlayerInRange && Input.GetButtonDown("Jump"))
        {
            if (!didDialogueStart)
            {
                StartDialogue();
            }
            else if (dialogueText.text == dialogueLines[lineIndex]) //Si muestra la linea de texto completa pasa a la siguiente.
            {
                NextDialogueLine();
            }
            else
            {
                StopAllCoroutines(); //muestra rapido
                dialogueText.text = dialogueLines[lineIndex];
            }
        }
    }

    private void StartDialogue()
    {
        didDialogueStart = true;
        dialoguePanel.SetActive(true);
        lineIndex = 0;
        Time.timeScale = 0f;
        StartCoroutine(Showline());
    }

    private void NextDialogueLine()
    {
        lineIndex++;
        if(lineIndex < dialogueLines.Length)
        {
            StartCoroutine(Showline());
        }
        else
        {
            didDialogueStart=false;
            dialoguePanel.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    //Corrutina,permite hacer cosas como pausar la ejecucion y retomarladuarante un cierto tiempo
    private IEnumerator Showline()
    {
        dialogueText.text = string.Empty;

        foreach(char ch in dialogueLines[lineIndex])
        {
            dialogueText.text += ch;
            yield return new WaitForSecondsRealtime(typingTime); //efecto de tipeo, espera un instante
        }
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = true;
            Debug.Log("Puede iniciar la zona");
        }
        
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerInRange = false;
            Debug.Log("No puede iniciar la zona");
        }
        
    }
}
