using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class TimerProgress : MonoBehaviour
{
    Image image;
    public float time;
    public float timetofinish = 10;
    TextMeshProUGUI text;
    public bool hasTime = true;
    public bool active = false;
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
        if(time > 0 && hasTime && active)
        {

            if ((int)time > 5)
            {
                text.color = Color.green;
            }

            if ((int)time < 5)
            {
                text.color = Color.yellow;
            }


            if ((int)time < 1)
            {
                text.color = Color.red;
            }
            time -= Time.deltaTime;
            image.fillAmount = time / timetofinish;
            text.text = "" + (int)time;

        }
        else if(time <= 0 && active)
        {
            hasTime = false;
        }
        
    }

    public void Reset()
    {
        time = timetofinish;
        hasTime = true;
}
}
