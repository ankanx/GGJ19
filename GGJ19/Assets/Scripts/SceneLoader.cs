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
    }

    public void LoadScene (int SceneIndex,SaveData save)
    {
        SceneManager.LoadScene(SceneIndex);   
    }
} 
