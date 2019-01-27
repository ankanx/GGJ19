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
    public DialogueManager dialogueManager;

    public Scene thisScene;
    private Canvas DialogueCanvas;
    private Canvas ChoiseCanvas;
    private SceneLoader loaderofscenes;

    bool movingToNextScene = false;

    // Start is called before the first frame update
    void Start()
    {

        DialogueCanvas = DialogObj.GetComponent<Canvas>();
        ChoiseCanvas = ChoiseObj.GetComponent<Canvas>();

        SaveState = GameObject.FindGameObjectWithTag("SaveStateHandler").GetComponent<SaveState>();
        loaderofscenes = GetComponent<SceneLoader>();
        ChoisesMade = SaveState.ChoisesMade;

        Debug.Log(this.name + ChoisesMade.Count);
        Debug.Log(SceneManager.GetActiveScene().name);
        Debug.Log(this.name + thisScene);



        switch (SceneManager.GetActiveScene().name)
        {
            case "StartScene":
                thisScene = Scene.Start;
                Invoke("Firstscene", 1);
                break;

            case "IntroScene":
                thisScene = Scene.Start;
                Invoke("IntroScene", 1);
                break;
            case "scene2":
                switch (SaveState.ChoisesMade[SaveState.ChoisesMade.Count-1].Choise)
                {
                    case Choise.First:
                        Invoke("Scene2A", 1);
                        break;
                    case Choise.Second:
                        Invoke("Scene2B", 1);
                        break;
                    case Choise.Third:
                        Invoke("Scene2C", 1);
                        break;
                }
                break;
            case "ChildInStairCaseScene":
                switch (SaveState.ChoisesMade[SaveState.ChoisesMade.Count - 1].Choise)
                {
                    case Choise.None:
                        Invoke("ChildInStairCaseScene", 1);
                        break;
                }
                break;
            case "ChildInStairCaseScene2":
                switch (SaveState.ChoisesMade[SaveState.ChoisesMade.Count - 1].Choise)
                {
                    case Choise.First:
                        Invoke("ChildInStairCaseScene2", 1);
                        break;
                    case Choise.Second:
                        Invoke("ChildInStairCaseScene2", 1);
                        break;
                    case Choise.Third:
                        Invoke("ChildInStairCaseScene2", 1);
                        break;
                    case Choise.Waited:
                        Invoke("ending3", 1);
                        break;
                }
                break;
            case "Oldladyscene":
                        Invoke("Oldladyscene", 1);
                break;
            case "ending1":
                switch (SaveState.ChoisesMade[SaveState.ChoisesMade.Count - 1].Choise)
                {
                    case Choise.First:
                        Invoke("ending1", 1);
                        break;
                }
                break;
            case "ending2":
                switch (SaveState.ChoisesMade[SaveState.ChoisesMade.Count - 1].Choise)
                {
                    case Choise.Second:
                        Invoke("ending2", 1);
                        break;
                    case Choise.Third:
                        Invoke("ending2", 1);
                        break;
                }
                break;
            case "ending3":
               
                        Invoke("ending3", 1);
                        break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (choiseHandler.decided && !movingToNextScene)
        {
            CheckCurrentChoiseAndLoadNextScene();
        }
    }

    public void Firstscene()
    {
        TriggerSpeach("start");
    }

    public void IntroScene()
    {
        TriggerSpeach("Intro");
    }

    public void Scene2A()
    {
        TriggerSpeach("scene2A");
    }

    public void Scene2B()
    {
        TriggerSpeach("scene2B");
    }

    public void Scene2C()
    {
        TriggerSpeach("scene2C");
    }

    public void ChildInStairCaseScene()
    {
        TriggerSpeach("child");
    }

    public void ChildInStairCaseScene2()
    {
        TriggerSpeach("child2");
    }

    public void Oldladyscene()
    {
        TriggerSpeach("lady");
    }

    public void ending1()
    {
        TriggerSpeach("ending1");
    }

    public void ending2()
    {
        TriggerSpeach("ending2");
    }

    public void ending3()
    {
        TriggerSpeach("ending3");
    }

    public void TriggerChoise()
    {
        ChoiseCanvas.enabled = true;
        DialogueCanvas.enabled = false;
        choiseHandler.active = true;
        choiseHandler.ChoiseTimer.GetComponent<TimerProgress>().active = true;
    }

    public void nochoise()
    {
        DialogueCanvas.enabled = false;
        CheckCurrentChoiseAndLoadNextScene();
    }

    public void TriggerSpeach(string speach)
    {
        ChoiseCanvas.enabled = false;
        DialogueCanvas.enabled = true;
        choiseHandler.active = false;
        choiseHandler.Resetchoises();
        choiseHandler.ChoiseTimer.GetComponent<TimerProgress>().active = false;
        choiseHandler.ChoiseTimer.GetComponent<TimerProgress>().Reset();
        dialogueManager.TriggerDialogue(speach);

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
        Debug.Log(SceneManager.GetActiveScene().name + "Checking current choises and moving on");

            // First Scene
            if(SceneManager.GetActiveScene().name == "StartScene" && choiseHandler.MadeChoise == Choise.First)
            {
                SaveState.ChoisesMade.Add(new SceneChoise(Scene.Start, Choise.First, 1));
                loaderofscenes.LoadSceneFromMenu(8);
            }

            if (SceneManager.GetActiveScene().name == "StartScene" && choiseHandler.MadeChoise == Choise.Second)
            {
                SaveState.ChoisesMade.Add(new SceneChoise(Scene.Start, Choise.Second, 1));
                loaderofscenes.LoadSceneFromMenu(8);
            }

            if (SceneManager.GetActiveScene().name == "StartScene" && choiseHandler.MadeChoise == Choise.Third)
            {
                SaveState.ChoisesMade.Add(new SceneChoise(Scene.Start, Choise.Third, 1));
                loaderofscenes.LoadSceneFromMenu(8);
            }

            // DEATH
            if (SceneManager.GetActiveScene().name == "StartScene" && choiseHandler.MadeChoise == Choise.Waited)
            {
                loaderofscenes.LoadSceneFromMenu(5);
            }
            // End First Scene

            // second Scene
            if (SceneManager.GetActiveScene().name == "scene2")
            {
                SaveState.ChoisesMade.Add(new SceneChoise(Scene.scene2, Choise.None, 1));
                loaderofscenes.LoadSceneFromMenu(9);
            }



            // third Scene
            if (SceneManager.GetActiveScene().name == "ChildInStairCaseScene" && choiseHandler.MadeChoise == Choise.First)
            {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.ChildInStairCaseScene, Choise.First, 1));
            loaderofscenes.LoadSceneFromMenu(11);

            }

            if (SceneManager.GetActiveScene().name == "ChildInStairCaseScene" && choiseHandler.MadeChoise == Choise.Second)
            {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.ChildInStairCaseScene, Choise.Second, 1));
            loaderofscenes.LoadSceneFromMenu(11);
            }

            if (SceneManager.GetActiveScene().name == "ChildInStairCaseScene" && choiseHandler.MadeChoise == Choise.Third)
            {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.ChildInStairCaseScene, Choise.Third, 1));
            loaderofscenes.LoadSceneFromMenu(11);
            }

        if (SceneManager.GetActiveScene().name == "ChildInStairCaseScene" && choiseHandler.MadeChoise == Choise.Waited)
        {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.ChildInStairCaseScene, Choise.Third, 1));
            loaderofscenes.LoadSceneFromMenu(14);
        }

        // forth Scene
        if (SceneManager.GetActiveScene().name == "ChildInStairCaseScene2")
            {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.ChildInStairCaseScene, Choise.None, 1));
            loaderofscenes.LoadSceneFromMenu(10);
            }


            // fifth Scene
            if (SceneManager.GetActiveScene().name == "Oldladyscene" && choiseHandler.MadeChoise == Choise.First)
            {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.Oldladyscene, Choise.First, 1));
            loaderofscenes.LoadSceneFromMenu(12);
            }

            if (SceneManager.GetActiveScene().name == "Oldladyscene" && choiseHandler.MadeChoise == Choise.Second)
            {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.Oldladyscene, Choise.Second, 1));
            loaderofscenes.LoadSceneFromMenu(13);
            }

            if (SceneManager.GetActiveScene().name == "Oldladyscene" && choiseHandler.MadeChoise == Choise.Third)
            {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.Oldladyscene, Choise.Third, 1));
            loaderofscenes.LoadSceneFromMenu(13);
            }

        if (SceneManager.GetActiveScene().name == "Oldladyscene" && choiseHandler.MadeChoise == Choise.Waited)
        {
            SaveState.ChoisesMade.Add(new SceneChoise(Scene.Oldladyscene, Choise.Third, 1));
            loaderofscenes.LoadSceneFromMenu(14);
        }




        if (SceneManager.GetActiveScene().name == "ending1")
        {
            loaderofscenes.LoadSCenesViaLoadingScene(1);
        }
        if (SceneManager.GetActiveScene().name == "ending2")
        {
            loaderofscenes.LoadSCenesViaLoadingScene(1);
        }
        if (SceneManager.GetActiveScene().name == "ending3")
        {
            loaderofscenes.LoadSCenesViaLoadingScene(1);
        }






        // debug
        if (thisScene == Scene.Template && choiseHandler.MadeChoise == Choise.Waited)
            {
                loaderofscenes.LoadSceneFromMenu(2);
            }
            // debug

        movingToNextScene = true;
    }


    public void ReturnToMainScreen()
    {
        loaderofscenes.LoadSCenesViaLoadingScene(1);
    }

    public void StartAdventure()
    {
        loaderofscenes.LoadSceneFromMenu(2);
    }
}
