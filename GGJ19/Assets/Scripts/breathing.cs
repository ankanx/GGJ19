using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class breathing : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("blink", 3.0f, 2f);
    }

    public void blink()
    {
        GetComponent<Animator>().SetTrigger("blink");
    }
}
