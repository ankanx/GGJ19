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
            "Archmage Bevac would never be able to enslave her world.",
            "She threw one last glance at the portal altar before:"
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

    /*
    * Contains a list of lists of strings, each list of strings is
    * a conversation element for the CHARACTER DEATH BY FALLING
    */
    public List<List<string>> FallingTodeath = new List<List<string>>{
        new List<string> {
            "Poppy exits from the balcony...",
            "The pavement came closer at lightning speed.",
            "She prepared to meet her maker.",
            "Poppy died."
        }
    };

    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> Intro = new List<List<string>>{
        new List<string> {
 "Evil Archmage Bevac has threatened to take over other worlds in order to extract their magic.",
            "His own world is slowly dying. All magical energy has almost been spent, and humans have braved forward creating new technologies that spew CO2 into the atmosphere. ",
            "Poppy and her comrades bravely traveled into the mage’s world to stop the mage.",
            "In the end, the only way to stop him was to destroy the portal altar. ",
            "She managed to get her comrades through the portal, before making the sacrifice of staying behind to save everyone. . . " 
        }
    };


    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> scene2A = new List<List<string>>{
        new List<string> {
            "She unceremoniously left through the front door." 
        }
    };


    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> scene2B = new List<List<string>>{
        new List<string> {
            "Poppy took a glance at the library.",
            "A strange book hummed softly amongst the dusty tomes. As if transfixed, she pocketed the book before exiting the house.  " 
        }
    };


    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> scene2C = new List<List<string>>{
        new List<string> {
            "The smell of some kind of fowl wafted through her nose and made her mouth water.",
            "She was hungry. Such an ordinary feeling almost made her laugh." 
        }
    };

    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> child = new List<List<string>>{
        new List<string> {
            "A child with dirty blond hair and snot huddled in the staircase."

        }
    };

    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> child2 = new List<List<string>>{
        new List<string> {
            "The child looked up at her.",
            "Where are your parents?",             "The child just shaked their head.",
            "What's your name?",             "... Mathilda.",             "Do you want to come with me Mathilda?",             "She looked uncertain at first, but got up and took Poppy's hand." 

        }
    };

    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> lady = new List<List<string>>{
        new List<string> {
            "An old suspicious lady appears.",             "´I know you are not from this world, I can help you get home´ the old lady said.´"

        }
    };

    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> ending1 = new List<List<string>>{
        new List<string> {
        "'You really should be more distrustful of strangers,' the lady lamented.",
        "'But you don’t look that dangerous?'",
        "'You never know child,” she said and sighed.",
        "'I guess you have more experience in this world than I do… Actually if it means that there is a risk that people will come through again I don’t want to go back to my home world.'",         "The lady stared at her long and hard. Finally after what seemed like an eternity she made up her mind.",
        "You are right, it’s not worth the risk trying to get you over there. Come with me instead, I will protect you from my brother Bevac.” Old lady Thelma took in Poppy and Mathilda.",
            "Together they thwarted Archmage Bevac’s plans whenever he came up with something new and devious.",
            "In a place far from her own world Poppy had found a place to belong, and a family. Poppy was home."

        }
    };

    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> ending2 = new List<List<string>>{
        new List<string> {
"'Because I’m your only way of getting home, and I want to stop my brother Bevac from gaining power. I’m his big sister Thelma.' She stared down Poppy.",
"'I sense that you have an important book. A book you took from my brother. With it I can send you to your homeworld.",
            "I only have one condition, please take me with you.'",
"This was Poppy’s chance to get home.",
            "If old lady Thelma and the book came with her she could make sure that Bevac could never step foot into her world again. She gripped Mathilda’s hand tightly.",
"'Ok, get us over there.'",
"Poppy was going home."

        }
    };

    /*
* Contains a list of lists of strings, each list of strings is
* a conversation element for the Intro
*/
    public List<List<string>> ending3 = new List<List<string>>{
        new List<string> {
        "Poppy promptly ignored them. It is what it is. Home was gone. "

        }
    };


}
