using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class loading : MonoBehaviour
{
    Image image;
    public float time;
    public float timetofinish = 10;
    TextMeshProUGUI text;
    SaveState Savestatehandler;

    // Start is called before the first frame update
    void Start()
    {
        Savestatehandler = GameObject.FindGameObjectWithTag("SaveStateHandler").GetComponent<SaveState>();
        text = GetComponentInChildren<TextMeshProUGUI>();
        image = GetComponent<Image>();
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (time < timetofinish)
        {

            if ((int)time > 0)
            {
                text.text = "Loading .";
            }

            if ((int)time > 1)
            {
                text.text = "Loading . .";
            }

            if ((int)time > 2)
            {
                text.text = "Loading . . .";
            }

            time += Time.deltaTime;
            image.fillAmount = time / timetofinish;

        }
        else
        {
            SceneManager.LoadScene(Savestatehandler.SceneToLoad);
        }

    }
}
