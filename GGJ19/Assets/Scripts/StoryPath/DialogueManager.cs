﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{
    public PathHandler pathhandler;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    private bool sceneEnded = false;
    // We can change this if we think there is a better approach
    // the queue is FIFO (First In First Out)
    public Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();

        Invoke("startdialog", 2);
    
    }

    public void startdialog()
    {
        if (!sceneEnded)
        {
            TriggerDialogue(Choise.First, Scene.Start);
            sceneEnded = true;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && (!sceneEnded))
        {
            TriggerDialogue(Choise.First, Scene.Start);
            sceneEnded = true;
        }
    }

    public void StartDialogue(List<List<string>> listOfDialogue)
    {
        // TODO: now here it says the DialogueManager name
        nameText.text = gameObject.name;
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
        StartCoroutine(WaitFiveSeconds());
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    IEnumerator WaitFiveSeconds()
    {
        yield return new WaitForSeconds(3.0f);
        // if we want the text just to keep going without pressing continue, use DisplayNextSentence
        DisplayNextSentence();
    }

    void EndDialogue()
    {
        pathhandler.TriggerChoise();
        Debug.Log("End of conversation");
    }

    public void TriggerDialogue(Choise choise, Scene scene)
    {
        if (scene == Scene.Start)
        {
            List<List<string>> playerSpeachStart = FindObjectOfType<Dialogue>().PlayerSpeachStart;
            StartDialogue(playerSpeachStart);
        }

    }
}
