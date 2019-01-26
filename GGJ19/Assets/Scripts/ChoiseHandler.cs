using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiseHandler : MonoBehaviour
{

    public GameObject ChoiseOne;
    public GameObject ChoiseTwo;
    public GameObject ChoiseThree;

    public GameObject ChoiseTimer;
    public Choise MadeChoise;

    // Start is called before the first frame update
    void Start()
    {
        MadeChoise = Choise.None;
    }

    // Update is called once per frame
    void Update()
    {
        if (!ChoiseTimer.GetComponent<TimerProgress>().hasTime)
        {
            ChoiseOne.GetComponent<Button>().interactable = false;
            ChoiseTwo.GetComponent<Button>().interactable = false;
            ChoiseThree.GetComponent<Button>().interactable = false;
            if(MadeChoise == Choise.None)
            {
                MadeChoise = Choise.Waited;
            }
        }
    }

    public void makechoise(int choise)
    {
        switch (choise)
        {
            case 1:
                MadeChoise = Choise.First;
                break;
            case 2:
                MadeChoise = Choise.Second;
                break;
            case 3:
                MadeChoise = Choise.Third;
                break;
        }
    }
}
