using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
        SaveLoad.Load();
        string debugstring = "Debug : \n " + "Player Name: " + SaveLoad.CurrentSave.PlayerName + "\n Progress: " + SaveLoad.CurrentSave.progress + "\n "; 
        Debug.Log(debugstring);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
