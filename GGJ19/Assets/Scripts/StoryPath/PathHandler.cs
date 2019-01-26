using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PathHandler : MonoBehaviour
{

    public List<SceneChoise> ChoisesMade;
    public SaveState SaveState;
    public ChoiseHandler choiseHandler;
    public GameObject DialogObj;
    public GameObject ChoiseObj;

    public Scene thisScene;
    private Canvas DialogueCanvas;
    private Canvas ChoiseCanvas;
    private SceneLoader loaderofscenes;

    bool movingToNextScene = false;

    // Start is called before the first frame update
    void Start()
    {

        switch (SceneManager.GetActiveScene().name)
        {
            case "Start":
                thisScene = Scene.Start;
                break;

            case "Template_scene":
                thisScene = Scene.Start;
                break;
            case "Template_scene_2":
                thisScene = Scene.Template;
                break;
        }

        DialogueCanvas = DialogObj.GetComponent<Canvas>();
        ChoiseCanvas = ChoiseObj.GetComponent<Canvas>();
        ChoiseCanvas.enabled = false;
        DialogueCanvas.enabled = true;

        SaveState = GameObject.FindGameObjectWithTag("SaveStateHandler").GetComponent<SaveState>();
        loaderofscenes = GetComponent<SceneLoader>();
        ChoisesMade = SaveState.ChoisesMade;

        Debug.Log(this.name + ChoisesMade.Count);
        Debug.Log(SceneManager.GetActiveScene().name);
        Debug.Log(this.name + thisScene);
    }

    // Update is called once per frame
    void Update()
    {
        if (choiseHandler.decided && !movingToNextScene)
        {
            CheckCurrentChoiseAndLoadNextScene();
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            ChoiseCanvas.enabled = true;
            DialogueCanvas.enabled = false;
            choiseHandler.active = true;
            choiseHandler.ChoiseTimer.GetComponent<TimerProgress>().active = true;
        }
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

    /*
     * This is gonna go and become a god function
     */
    public void CheckCurrentChoiseAndLoadNextScene()
    {
        Debug.Log(this.name + "Checking current choises and moving on");
        if(choiseHandler.MadeChoise != Choise.None)
        {
            // First Scene
            if(thisScene == Scene.Start && choiseHandler.MadeChoise == Choise.First)
            {
                loaderofscenes.LoadSceneFromMenu(3);
            }

            if (thisScene == Scene.Start && choiseHandler.MadeChoise == Choise.Second)
            {
                loaderofscenes.LoadSceneFromMenu(3);
            }

            if (thisScene == Scene.Start && choiseHandler.MadeChoise == Choise.Third)
            {
                loaderofscenes.LoadSceneFromMenu(3);
            }

            if (thisScene == Scene.Start && choiseHandler.MadeChoise == Choise.Waited)
            {
                loaderofscenes.LoadSceneFromMenu(3);
            }
            // End First Scene


            // debug
            if (thisScene == Scene.Template && choiseHandler.MadeChoise == Choise.Waited)
            {
                loaderofscenes.LoadSceneFromMenu(2);
            }
            // debug















        }
        else
        {

        }

        movingToNextScene = true;
    }
}
