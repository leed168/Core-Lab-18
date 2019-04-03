using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager_SpeedHUDVer : MonoBehaviour
{
    public GameObject Player;

    public Text DialogueText;

    private Queue<string> sentences;

    public Animator DialogueBoxAnimator;
    public Animator SpeedHUDAnimator;
    public Animator SpeedHUDTextAnimator;

    public Font Font;



    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue (Dialogue dialogue)
    {
        Player.GetComponent<PlayerController_Scene3>().enabled = false;
        Player.GetComponent<Animator>().enabled = false;
        DialogueText.GetComponent<Text>().font = Font;



        DialogueBoxAnimator.SetBool("IsOpen", true);

        //Debug.Log("Starting Conversation with " + dialogue.name);

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence (string sentence)
    {
        DialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            DialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        DialogueBoxAnimator.SetBool("IsOpen", false);

        SpeedHUDAnimator.SetBool("IsOpen", true);
        SpeedHUDTextAnimator.SetBool("IsOpen", true);

        Invoke("PlayerEnableAgain", 3);
    }

    void PlayerEnableAgain()
    {
        Player.GetComponent<PlayerController_Scene3>().enabled = true;
        Player.GetComponent<Animator>().enabled = true;
    }
}
