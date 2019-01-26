using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenu : MonoBehaviour
{
    public Canvas menuCanvas;

    // Start is called before the first frame update
    void Start()
    {
        menuCanvas = GetComponent<Canvas>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Cancel"))
        {
            menuCanvas.enabled = !menuCanvas.enabled;
            if(menuCanvas.enabled == true)
            {
                Time.timeScale = 0f;
            }
            else
            {
                Time.timeScale = 1f;
            }
            
        }
    }
}
