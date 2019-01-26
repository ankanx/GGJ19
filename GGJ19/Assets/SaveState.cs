using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    public static SaveState Instance { get; set; }

    public List<SceneChoise> ChoisesMade = new List<SceneChoise>();
    public int num;
    public int SceneToLoad;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        ChoisesMade.Add(null);
    }

    private void OnLevelWasLoaded(int level)
    {
        num = ChoisesMade.Count;
        Debug.Log(this.name + ChoisesMade.Count);
    }

}
