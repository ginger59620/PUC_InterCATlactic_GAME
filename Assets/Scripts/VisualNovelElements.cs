using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VisualNovelElements : MonoBehaviour
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
        //Stripes startting
        Character1.SetActive(true);

        yield return new WaitForSeconds(0.1f);
        mainTextObject.SetActive(true);
        textToSpeak = "What is this?"; //stripes talkes
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
        Character2.SetActive(true); //Chanchal apears (stipes still on screen)

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Is the GPS broken?";
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
        nextButton.SetActive(false);

        Character1.SetActive(false); //stripes leaves
        Character2.SetActive(true); //chanchal stays
        Character3.SetActive(true); //Sailor shows up

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Sailor"; //The character name chances to sailot (the one talikng)
        textToSpeak = "I know what i am doing. We are in Uranus.";
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
        nextButton.SetActive(false);
      
        Character3.SetActive(false); //Sailor leaves
        Character1.SetActive(true);  //Stripes appears
        Character2.SetActive(true); //chanchal stays

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Both"; //The character name chances to both (the one talikng)

        textToSpeak = "pff...";
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
        nextButton.SetActive(false);

        Character1.SetActive(false);  //Stripes leaves
        Character2.SetActive(false); //chanchal leaves

        Character4.SetActive(true); //Starz Appears

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances the one talikng

        textToSpeak = "This? This is our next tour!";
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
        nextButton.SetActive(false);

        Character4.SetActive(true); //Starz Stays
        Character5.SetActive(true); //Zly Shows up

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances the one talikng

        textToSpeak = "Uuummmh… excuse me? Who are you guy?";
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
        nextButton.SetActive(false);

        Character4.SetActive(true); //Starz Stays
        Character5.SetActive(true); //Zly Shows up

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances the one talikng

        textToSpeak = "We are your next SUPERSTARS!";
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
        //event 5
        nextButton.SetActive(false);

        Character4.SetActive(true); //Starz stays
        Character5.SetActive(false); //Zly leaves
        Character1.SetActive(true); //Stripes shows up

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stripes"; //The character name chances the one talikng

        textToSpeak = "WE ARE GOING TO FUCKING KILL YOU";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        Character4.SetActive(true); //Starz stays
        Character5.SetActive(true); //Zly leaves
        Character1.SetActive(false); //Stripes shows up

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances the one talikng
        textToSpeak = "W-WHAT?";
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
        nextButton.SetActive(false);

        Character4.SetActive(true); //Starz ON
        Character1.SetActive(false); //Stripes OFF
        Character5.SetActive(true); //Zly ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances the one talikng

        textToSpeak = "Prepare to be ROCKED to your CORE!";
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
        //event 9
        nextButton.SetActive(false);

        Character4.SetActive(true); //Starz ON
        Character5.SetActive(true); //Zly ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances the one talikng

        textToSpeak = "P-please I have a family!";
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
        //event 10
        Character4.SetActive(false); //Starz OFF
        Character5.SetActive(true); //Zly ON
        Character2.SetActive(true); //Chanchal ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal"; //The character name chances the one talikng

        textToSpeak = "Aw... Too bad!";
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
        //event 11
        Character5.SetActive(true); //Zly ON
        Character2.SetActive(true); //Chanchal ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances the one talikng

        textToSpeak = "P-please! I still have so much to do! I still want to see my kids grow up… ";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        yield return new WaitForSeconds(1);
        Character5.SetActive(true); //Zly ON
        Character2.SetActive(true); //Chanchal ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances the one talikng
        textToSpeak = "I-I want them to have a future, to have a life...";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true);
        eventPos = 12;
    }

    IEnumerator Event12()
    {
        //event 12
        Character5.SetActive(false); //Zly OFF
        Character2.SetActive(false); //Chanchal OFF
        Character3.SetActive(true); //Sailor ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Sailor"; //The character name chances the one talikng

        textToSpeak = "Give us the mango!";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true);
        eventPos = 13;
    }
    IEnumerator Event13()
    {
        //event 13
        Character3.SetActive(false); //Sailor OFF
        Character5.SetActive(true); //Zly ON

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances the one talikng

        textToSpeak = "M-Mango? I don’t know what that is! Please you HAVE to believe me! ";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        gameplayButton.SetActive(true);
        eventPos = 13;
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
        if (eventPos == 12)
        {
            StartCoroutine(Event12());
        }
        if (eventPos == 13)
        {
            StartCoroutine(Event13());
        }
    }
}
