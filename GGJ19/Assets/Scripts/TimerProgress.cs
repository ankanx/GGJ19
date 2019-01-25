using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TimerProgress : MonoBehaviour
{
    Image image;
    private float time;
    public float timetofinish = 10;
    TextMeshProUGUI text;
    public bool hasTime = true;

    // Start is called before the first frame update
    void Start()
    {
        text = GetComponentInChildren<TextMeshProUGUI>();
        image = GetComponent<Image>();
        time = timetofinish;
    }

    // Update is called once per frame
    void Update()
    {
        if(time > 0)
        {
            time -= Time.deltaTime;
            image.fillAmount = time / timetofinish;
            text.text = "" + (int)time;
        }
        else
        {
            hasTime = false;
        }
        
    }
}
