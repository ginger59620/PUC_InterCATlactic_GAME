using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class VNpart3 : MonoBehaviour
{
    public GameObject Character1, Character2, Character3, Character4, Character5, Character6, specialChara;
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

        textToSpeak = "UGH! THIS PLACE SUCKS!";
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

        Character1.SetActive(true); //stripes
        Character2.SetActive(true); //chanchal

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Yeah… Let’s just kill them for mercy, i guess.";
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
        nextButton.SetActive(false); //The next button goes off

        Character1.SetActive(true); //stripes
        Character2.SetActive(false); //chanchal
        Character3.SetActive(true); //Stieekz

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stieekz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Yeah! They don’t have what we want.";
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
        nextButton.SetActive(false); //The next button goes off

        Character1.SetActive(true); //stripes
        Character3.SetActive(false); //Stieekz

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stripes"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Do you know where the supreme mango is?";
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
        nextButton.SetActive(false); //The next button goes off

        Character1.SetActive(false); //stripes
        Character4.SetActive(true); //zly
        

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "I... already... told you... I don't... know what… that is...";
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
        nextButton.SetActive(false); //The next button goes off

        Character4.SetActive(false); //zly
        Character1.SetActive(true); //stripes
        
        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Stripes"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Pathetic...";
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
        nextButton.SetActive(false); //The next button goes off

        Character1.SetActive(false); //stripes
        Character5.SetActive(true); //Sailor

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Sailor"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Do you know where we can find it?";
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
        nextButton.SetActive(false); //The next button goes off

        Character5.SetActive(false); //Sailor
        Character4.SetActive(true); //Zly

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "I...don’t...know…\r\nIt sounds...that it’s from...closer to the sun...";
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
        nextButton.SetActive(false); //The next button goes off

        Character4.SetActive(false); //Zly
        specialChara.SetActive(true); //all kalines

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "All"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "CLOSE TO THE SUN!";
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

        specialChara.SetActive(false); //all kalines
        Character4.SetActive(true); //Zly

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Zly"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Please...leave us...alone...";
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

        Character4.SetActive(false); //Zly
        Character2.SetActive(true); //chanchal

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "Alright, now we know.\r\nLet’s go close to the sun!";
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

        Character2.SetActive(false); //chanchal
        Character6.SetActive(true); //Starz

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Starz"; //The character name chances to chanchal (the one talikng)
        textToSpeak = "But first, let’s leave with a BANGER!";
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
