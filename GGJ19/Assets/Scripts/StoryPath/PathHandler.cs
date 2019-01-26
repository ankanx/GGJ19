using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathHandler : MonoBehaviour
{

    public List<SceneChoise> ChoisesMade;
    public SaveState SaveState;
    public ChoiseHandler choiseHandler;

    // Start is called before the first frame update
    void Start()
    {
        SaveState = GameObject.FindGameObjectWithTag("SaveStateHandler").GetComponent<SaveState>();
        ChoisesMade = SaveState.ChoisesMade;
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
