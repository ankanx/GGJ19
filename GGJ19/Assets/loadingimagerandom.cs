using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class loadingimagerandom : MonoBehaviour
{

    Sprite templatekun;
    Sprite test;
    Sprite poppy;
    List<Sprite> characterList = new List<Sprite>();

    

    // Start is called before the first frame update
    void Start()
    {
        templatekun = Resources.Load<Sprite>("Images/PLACEHOLDER_CH");
        test = Resources.Load<Sprite>("Images/Progress");
        poppy = Resources.Load<Sprite>("Images/poppy");
        characterList.Add(templatekun);
        characterList.Add(test);
        characterList.Add(poppy);
        int ran = Random.Range(0, characterList.Count);
        Debug.Log(ran);
        GetComponent<Image>().sprite = characterList[ran];

    }

}
