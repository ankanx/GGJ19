using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Dialogue : MonoBehaviour
{

    //public string name;
    //public string[] sentences;

    /*
     * 
     * Contains a list of lists of strings, each list of strings is
     * a conversation element for the PLAYER
     */
    public List<List<string>> PlayerSpeachStart = new List<List<string>>{
        new List<string> {
            "It was like someone had pulled the plug out of a bathtub.",
            "The portal closed with a last sucking noise.",
            "Poppy watched as the last view of home flickered out of existence. It was done.",
            "Archmage Bevac would never be able to enslave her world."

        }
    };

    /*
     * Contains a list of lists of strings, each list of strings is
     * a conversation element for the CHARACTER1
     */
    public List<List<string>> Character1 = new List<List<string>>{
        new List<string> {
            "Sentence Character 1"
        },
        new List<string> {
            "",
            ""
        },
        new List<string> {
            "",
            ""
        }
    };

    /*
    * Contains a list of lists of strings, each list of strings is
    * a conversation element for the CHARACTER1
    */
    public List<List<string>> Scene1 = new List<List<string>>{
        new List<string> {
            "Sentence 1",
            "Sentence 2",
            "Sentence 3"
        }
    };


}
