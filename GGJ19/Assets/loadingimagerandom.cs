using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class loadingimagerandom : MonoBehaviour
{

    Sprite templatekun;
    Sprite test;
    List<Sprite> characterList = new List<Sprite>();

    

    // Start is called before the first frame update
    void Start()
    {
        templatekun = Resources.Load<Sprite>("Images/PLACEHOLDER_CH");
        test = Resources.Load<Sprite>("Images/Progress");
        characterList.Add(templatekun);
        characterList.Add(test);
        int ran = Random.Range(0, characterList.Count);
        Debug.Log(ran);
        GetComponent<Image>().sprite = characterList[ran];

    }

}
