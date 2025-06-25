using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisualNovelElements : MonoBehaviour
{
    public GameObject Character1, Character2;
    public GameObject textBox;

    //to add sound effect: "[serialixefield] audiosource blabla;" then under the character thing add "blabla.play()"

    [SerializeField] string textToSpeak;
    [SerializeField] int currentTextLength;
    [SerializeField] int textLenght;
    [SerializeField] GameObject mainTextObject;

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
        //event 0
        Character1.SetActive(true);

        yield return new WaitForSeconds(0.1f);
        mainTextObject.SetActive(true);
        textToSpeak = "What is this?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);

        nextButton.SetActive(true);
        eventPos = 1;
    }
    IEnumerator Event1()
    {
        //event 1
        nextButton.SetActive(false);
        Character2.SetActive(true);

        textBox.SetActive(true);
        charName.GetComponent<TMPro.TMP_Text>().text = "Chanchal";

        textToSpeak = "Is the GPS broken?";
        textBox.GetComponent<TMPro.TMP_Text>().text = textToSpeak;
        currentTextLength = textToSpeak.Length;
        TextCreator.runTextPrint = true;
        yield return new WaitForSeconds(0.05f);
        yield return new WaitForSeconds(1);
        yield return new WaitUntil(() => textLenght == currentTextLength);
        yield return new WaitForSeconds(0.05f);
        nextButton.SetActive(true);
    }

    public void NextButton()
    {
        if (eventPos == 1)
        {
            StartCoroutine(Event1());
        }
    }
}
