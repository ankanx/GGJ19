using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class loadingimagerandom : MonoBehaviour
{

    Sprite templatekun;
    Sprite test;
    Sprite poppy;
    Sprite poppysad;
    Sprite poppyhappy;
    Sprite poppyangry;
    List<Sprite> characterList = new List<Sprite>();

    

    // Start is called before the first frame update
    void Start()
    {
        templatekun = Resources.Load<Sprite>("Images/PLACEHOLDER_CH");
        test = Resources.Load<Sprite>("Images/Progress");
        poppy = Resources.Load<Sprite>("Images/poppy");
        poppyhappy = Resources.Load<Sprite>("Images/poppyhappy");
        poppysad = Resources.Load<Sprite>("Images/poppysad");
        poppyangry = Resources.Load<Sprite>("Images/poppyanger");
        characterList.Add(poppy);
        characterList.Add(poppysad);
        characterList.Add(poppyhappy);
        characterList.Add(poppyangry);
        int ran = Random.Range(0, characterList.Count);
        Debug.Log(ran);
        GetComponent<Image>().sprite = characterList[ran];
        GetComponent<Image>().SetNativeSize();
    }

}
