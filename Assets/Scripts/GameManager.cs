using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource theMusic;
    
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

    public float totalNotes;
    public float coolHits;
    public float sickHits;
    public float bangerHits;
    public float yikesHits;

    public GameObject resultsScreen; //how to make the result window pop up
    public Text totalhitsText, finalscoreText, rankText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        instance = this;

        scoreText.text = "Score 0";
        currentMultiplier = 1;

        totalNotes = FindObjectsOfType<NoteObject>().Length;
    }

    // Update is called once per frame
    void Update()
    {
        if (!startPlaying)
        {
            if (Input.anyKeyDown)
            {
                startPlaying = true;
                theBS.hasStarted = true;

                theMusic.Play();
            }
        }
        else
        {
            if (!theMusic.isPlaying && !resultsScreen.activeInHierarchy)
            {
                resultsScreen.SetActive(true);

                float totalHits = coolHits + sickHits + bangerHits;
                totalhitsText.text = totalHits.ToString();

                string rankVal = "F";

                if (totalHits > 134)
                {
                    rankVal = "D";

                    if (totalHits > 184)
                    {
                        rankVal = "C";

                        if (totalHits > 284)
                        {
                            rankVal = "B";

                            if (totalHits > 384)
                            {
                                rankVal = "A";

                                if (totalHits > 434)
                                {
                                    rankVal = "S";
                                }
                            }
                        }
                    }
                }

                rankText.text = rankVal;

                finalscoreText.text = currentScore.ToString();

            }
        }
    }

    public void NoteHit()
    {
      
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

        coolHits++;
    }
    public void SickHit()
    {
        currentScore += scorePerSickNote * currentMultiplier;
        NoteHit();

        sickHits++;
    }
    public void BangerHit()
    {
        currentScore += scorePerBangerNote * currentMultiplier;
        NoteHit();

        bangerHits++;
    }
    public void NoteMissed()
    { 
        currentMultiplier = 1;
        multiplierTracker = 0;

        multiText.text = "Combo: x" + currentMultiplier;

        yikesHits++;
    }
}
