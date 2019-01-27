using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathtrigger : MonoBehaviour
{
    public Animator anim;
    public PathHandler pathhandler;
    public string deathspeach;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("triggerdeathspeach", 0.3f);
        Invoke("triggerdeath", 4f);
    }

    public void triggerdeathspeach(){
        pathhandler.TriggerSpeach(deathspeach);
    }

    public void triggerdeath()
    {
        anim.SetTrigger("fall");
    }
}
