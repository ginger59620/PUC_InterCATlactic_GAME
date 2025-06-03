using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
   // public AudioSource Hit;
   //public AudioSource Miss;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;
    }

    // Update is called once per frame
    void Update()
    {
       if(!startPlaying)
        {
            if(Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
    }

    public void NoteHit()
    {
       // Hit.Play();
        Debug.Log("Hit On Time");
    }
    public void NoteMissed()
    {
       // Miss.Play();
        Debug.Log("Missed");
    }
}
