using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue_scene2 : MonoBehaviour
{
    public Text textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed;

    void Start()
    {
        StartCoroutine(type());
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "dialogueTrigger")
    //    {
    //        StartCoroutine(type());
    //    }
    //}

    void Update()
    {
        if (textDisplay.text == sentences[index])
        {
            pressContinue();
        }
    }

    void pressContinue()
    {
        if (Input.GetKey(KeyCode.Z))
        {
            nextSentence();
        }
        if (Input.GetKey(KeyCode.X))
        {
            endDialogue();
        }
    }

    IEnumerator type()
    {
        yield return new WaitForSeconds(1);
        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void nextSentence()
    {
        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(type());
        }
        else
        {
            textDisplay.text = "";
        }
    }

    public void endDialogue()
    {
        textDisplay.text = "";
    }

}
