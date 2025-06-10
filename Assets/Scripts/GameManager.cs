using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
   // public AudioSource Hit;
   //public AudioSource Miss;

    public bool startPlaying;

    public BeatScroller theBS;

    public static GameManager instance;

    public int currentScore;
    public int scorePerNote = 100;
    public int scorePerSickNote = 125;
    public int scorePerBangerNote = 150;

    public int currentMultiplier;
    public int multiplierTracker;
    public int[] multiplierThresholds;

    public Text scoreText;
    public Text multiText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;

        scoreText.text = "Score 0";
        currentMultiplier = 1;
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

        if (currentMultiplier - 1 < multiplierThresholds.Length)
        {
            multiplierTracker++;

            if (multiplierThresholds[currentMultiplier - 1] <= multiplierTracker)
            {
                multiplierTracker = 0;
                currentMultiplier++;
            }
        }

        multiText.text = "Combo: x" + currentMultiplier;

        //currentScore += scorePerNote * currentMultiplier;
        scoreText.text = "Score:" + currentScore;
    }
    public void CoolHit()
    {
        currentScore += scorePerNote * currentMultiplier;
        NoteHit();
    }
    public void SickHit()
    {
        currentScore += scorePerSickNote * currentMultiplier;
        NoteHit();
    }
    public void BangerHit()
    {
        currentScore += scorePerBangerNote * currentMultiplier;
        NoteHit();
    }
    public void NoteMissed()
    {
       // Miss.Play();
        Debug.Log("Missed");

        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Combo: x" + currentMultiplier;
    }
}
