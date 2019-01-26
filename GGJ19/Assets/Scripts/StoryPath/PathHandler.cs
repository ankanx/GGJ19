using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathHandler : MonoBehaviour
{

    public List<SceneChoise> ChoisesMade;
    public SaveState SaveState;
    public ChoiseHandler choiseHandler;
    public GameObject DialogObj;
    public GameObject ChoiseObj;

    private Canvas DialogueCanvas;
    private Canvas ChoiseCanvas;

    // Start is called before the first frame update
    void Start()
    {
        DialogueCanvas = DialogObj.GetComponent<Canvas>();
        ChoiseCanvas = ChoiseObj.GetComponent<Canvas>();
        //ChoiseCanvas.enabled = false;
        //DialogueCanvas.enabled = true;

        SaveState = GameObject.FindGameObjectWithTag("SaveStateHandler").GetComponent<SaveState>();

        ChoisesMade = SaveState.ChoisesMade;
        Debug.Log(this.name + ChoisesMade.Count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckLastChoise()
    {
        if(ChoisesMade.Count > 0)
        {
            Debug.Log(ChoisesMade[ChoisesMade.Count]);
            //ChoisesMade[ChoisesMade.Capacity]
        }
        else
        {
            Debug.Log("Number of choises made: " + ChoisesMade.Count);
        }

    }

    public void CheckCurrentChoiseAndLoadNextScene()
    {
        if(choiseHandler.MadeChoise != Choise.None)
        {

        }
        else
        {

        }
    }
}
