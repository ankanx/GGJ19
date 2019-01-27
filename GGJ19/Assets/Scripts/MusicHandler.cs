using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicHandler : MonoBehaviour
{

    public AudioSource AS;
    AudioClip newday;
    AudioClip ankanwow;

    public static MusicHandler Instance { get; set; }


    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);

        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        newday = Resources.Load<AudioClip>("Music/newday");
        ankanwow = Resources.Load<AudioClip>("Music/ankanwow");
        AS = GetComponent<AudioSource>();
        //PlayNewDaySound();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {

        }
    }


    public void PlayNewDaySound()
    {
        AS.PlayOneShot(newday);
    }

    public void PlayWoWSound()
    {
        AS.PlayOneShot(ankanwow);
    }
}
