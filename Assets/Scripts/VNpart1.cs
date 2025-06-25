using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VNpart1 : MonoBehaviour
{
    public GameObject Character1, Character2, Character3, Character4, Character5;
    public GameObject textBox;

    //to add sound effect: "[serialixefield] audiosource blabla;" then under the character thing add "blabla.play()"

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;

    public GameObject gameplayButton;

    [SerializeField] GameObject nextButton;
    [SerializeField] int eventPos = 0;

    [SerializeField] GameObject charName;


    void Update()
    {
        textLenght = TextCreator.charCount;
    }

    private void Start()
    {
        StartCoroutine(EventStarter());
    }

    IEnumerator EventStarter()
    {
        //event 0 (defoult)
        Character1.SetActive(true);

        yield return new WaitForSeconds(0.1f);
        mainTextObject.SetActive(true);

        textToSpeak = "Taste it! Taste it! TASTE IT!"; 
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true); //the next button shows up
        eventPos = 1; //goes to event 1
    }
    IEnumerator Event1()
    {
        //event 1
        nextButton.SetActive(false); //The next button goes off

        Character1.SetActive(false); //Chanchal OFF
        Character2.SetActive(true); //Stieekz ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stieekz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "What?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        Character3.SetActive(true); //Stripes ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Strips"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "GIVEEEEEEEEEEEEEEEEEEEEEEEEEEEEE!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true);
        eventPos = 2;
    }
    IEnumerator Event2()
    {
        //event 2
        nextButton.SetActive(false); //The next button goes off

        Character2.SetActive(false); //Stieekz Off
        Character3.SetActive(true); //Stripes ON
        Character4.SetActive(true); //Starz on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Come on guys, that thing can`t be that good... HORPY ZHIRT!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 3;
    }
    IEnumerator Event3()
    {
        //event 3
        nextButton.SetActive(false); //The next button goes off

        Character4.SetActive(false); //Starz off
        Character2.SetActive(true); //Stieekz on
        Character3.SetActive(true); //Stripes ON
      

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stieekz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Purrrh… Good, good!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 4;
    }
    IEnumerator Event4()
    {
        //event 4
        nextButton.SetActive(false); //The next button goes off

        Character2.SetActive(false); //Stieekz off
        Character3.SetActive(false); //Stripes off
        Character5.SetActive(true); //sailor on


        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Sailor"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Very good! I wonder where there is more!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 5;
    }
    IEnumerator Event5()
    {
        //event 5
        nextButton.SetActive(false); //The next button goes off

        Character5.SetActive(true); //sailor on
        Character1.SetActive(true); //Chanchal on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Probably out there, in the Milky Way!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 6;
    }
    IEnumerator Event6()
    {
        //event 6
        nextButton.SetActive(false); //The next button goes off

        Character5.SetActive(false); //sailor off
        Character1.SetActive(true); //Chanchal on
        Character3.SetActive(true); //Stripes on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stripes"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Let’s go look for it… and KILL anyone in the way!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
        eventPos = 7;
    }
    IEnumerator Event7()
    {
        //event 7
        nextButton.SetActive(false); //The next button goes off

        Character1.SetActive(false); //Chanchal off
        Character2.SetActive(true); //Stieekz on
        Character3.SetActive(true); //Stripes on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stieekz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Wha...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        Character2.SetActive(false); //Stieekz off
        Character4.SetActive(true); //Starz on
        Character3.SetActive(true); //Stripes on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "No, Stripes, we can't just kill people...Unless...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true);
        eventPos = 8;
    }
    IEnumerator Event8()
    {
        //event 8
        nextButton.SetActive(false); //The next button goes off

        Character3.SetActive(false); //Stripes off
        Character4.SetActive(true); //starz on
        Character5.SetActive(true); //sailor on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Sailor"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "No! not yet. Let’s focus on the mango... thing!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true);
        eventPos = 9;
    }
    IEnumerator Event9()
    {
        nextButton.SetActive(false); //The next button goes off

        Character4.SetActive(true); //starz on
        Character5.SetActive(true); //sailor on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Mango?\r\nI like the name! Yeah, let’s focus on the mango!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true);
        eventPos = 10;
    }
    IEnumerator Event10()
    {
        nextButton.SetActive(false); //The next button goes off

        Character4.SetActive(false); //starz 
        Character1.SetActive(true); //Chanchal
        Character5.SetActive(true); //sailor on

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "We can dominate the universe as we go, yeah?\r\n";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "But don’t forget about THE SUPREME MANGO THING!\r\n";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);


        nextButton.SetActive(true);
        eventPos = 11;
    }
    IEnumerator Event11()
    {
        nextButton.SetActive(false); //The next button goes off

        Character1.SetActive(false); //Chanchal
        Character4.SetActive(true); //starz 
        Character5.SetActive(true); //sailor 
        
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Hmm…\r\nMaybe, with the Mango…\r\n";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "I might be able to become the biggest superstar EVER!\r\nYes! That 's it!\r\n";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "I- well, we- will dominate the world with the Mango!\r\n";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        Character4.SetActive(true); //starz 
        Character5.SetActive(false); //sailor 
        Character3.SetActive(true); //Stripes

        yield return new WaitForSeconds(1);
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stripes"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "NHA NHA NHA NHA!!!!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);


        gameplayButton.SetActive(true);
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(Event1());
        }
        if (eventPos == 2)
        {
            StartCoroutine(Event2());
        }
        if (eventPos == 3)
        {
            StartCoroutine(Event3());
        }
        if (eventPos == 4)
        {
            StartCoroutine(Event4());
        }
        if (eventPos == 5)
        {
            StartCoroutine(Event5());
        }
        if (eventPos == 6)
        {
            StartCoroutine(Event6());
        }
        if (eventPos == 7)
        {
            StartCoroutine(Event7());
        }
        if (eventPos == 8)
        {
            StartCoroutine(Event8());
        }
        if (eventPos == 9)
        {
            StartCoroutine(Event9());
        }
        if (eventPos == 10)
        {
            StartCoroutine(Event10());
        }
        if (eventPos == 11)
        {
            StartCoroutine(Event11());
        }

    }
}
