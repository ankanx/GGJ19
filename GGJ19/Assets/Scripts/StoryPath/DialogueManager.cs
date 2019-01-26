using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueManager : MonoBehaviour
{ 
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI dialogueText;

    // We can change this if we think there is a better approach
    // the queue is FIFO (First In First Out)
    public Queue<string> sentences;
    
    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting conversation with " + dialogue.name);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
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
        yield return new WaitForSeconds(5.0f);
        // if we want the text just to keep going without pressing continue, we can use this
        //DisplayNextSentence();
    }

    void EndDialogue()
    {
        Debug.Log("End of conversation");
    }
}
