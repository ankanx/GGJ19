using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogueManager : MonoBehaviour
{
    public PathHandler pathhandler;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    public string InitDialogue;
    public string currentdialog = "";

    private bool sceneEnded = false;
    // We can change this if we think there is a better approach
    // the queue is FIFO (First In First Out)
    public Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    
    }

    public void startdialog()
    {
        if (!sceneEnded)
        {
            TriggerDialogue(InitDialogue);
            sceneEnded = true;
        }
    }

    public void StartDialogue(List<List<string>> listOfDialogue)
    {
        // this index is the first list of strings of the listOfDialogue, change it to loop to the next ones or make it different
        int index = 0;
        List<string> dialogue = listOfDialogue[index];

        sentences.Clear();
        foreach (string sentence in dialogue)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            sceneEnded = false;
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
        
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            yield return new WaitForSeconds(0.05f);
            dialogueText.text += letter;
            yield return null;
        }
        StartCoroutine(WaitFiveSeconds());
    }

    IEnumerator WaitFiveSeconds()
    {
        if(currentdialog == "fallingtodeath")
        {
            yield return new WaitForSeconds(2.0f);
        }
        else
        {
            yield return new WaitForSeconds(3.0f);
        }
        // if we want the text just to keep going without pressing continue, use DisplayNextSentence
        DisplayNextSentence();
    }

    void EndDialogue()
    {
        if(currentdialog == "fallingtodeath")
        {
            pathhandler.Invoke("ReturnToMainScreen", 2);
        }
        else if(currentdialog == "Intro")
        {
            pathhandler.Invoke("StartAdventure", 3);
        }
        else
        {
            pathhandler.TriggerChoise();
        }
        Debug.Log("End of conversation");
    }

    public void TriggerDialogue(string dialogue)
    {
        currentdialog = dialogue;
        if (dialogue == "start")
        {
            nameText.text = "Narrator";
            List<List<string>> playerSpeachStart = FindObjectOfType<Dialogue>().PlayerSpeachStart;
            StartDialogue(playerSpeachStart);
        }

        if(dialogue == "fallingtodeath")
        {
            nameText.text = "Narrator";
            List<List<string>> playerSpeachStart = FindObjectOfType<Dialogue>().FallingTodeath;
            StartDialogue(playerSpeachStart);
        }

        if (dialogue == "Intro")
        {
            nameText.text = "Narrator";
            List<List<string>> playerSpeachStart = FindObjectOfType<Dialogue>().Intro;
            StartDialogue(playerSpeachStart);
        }

    }
}
