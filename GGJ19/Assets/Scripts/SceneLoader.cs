using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class SceneLoader : MonoBehaviour {

    public static SceneLoader Instance { get; set; }

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
    }

    public void LoadScene (int SceneIndex,SaveData save)
    {
        SceneManager.LoadScene(SceneIndex);   
    }
} 
