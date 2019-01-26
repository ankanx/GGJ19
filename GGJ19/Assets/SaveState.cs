using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveState : MonoBehaviour
{
    public static SaveState Instance { get; set; }

    public List<SceneChoise> ChoisesMade;

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

        ChoisesMade = new List<SceneChoise>();
    }

}
