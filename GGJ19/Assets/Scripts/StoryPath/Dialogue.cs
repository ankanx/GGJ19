using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    /*
     * Contains a list of lists of strings, each list of strings is
     * a conversation element for the PLAYER
     */
    public List<List<string>> PlayerSpeach = new List<List<string>>{
            new List<string> {
                ""
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
    public List<List<string>> Character1 = new List<List<string>>{
        new List<string> {
            ""
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
}
