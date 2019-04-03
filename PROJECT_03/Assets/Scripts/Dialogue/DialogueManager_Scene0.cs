using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DialogueManager_Scene0 : MonoBehaviour
{
    public Text DialogueText;

    private Queue<string> sentences;

    public Animator DialogueBoxAnimator;

    public Font Font;

    void Start()
    {
        sentences = new Queue<string>();

    }

    public void StartDialogue(Dialogue dialogue)
    {
        DialogueBoxAnimator.SetBool("IsOpen", true);

        DialogueText.GetComponent<Text>().font = Font;
        
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

    IEnumerator TypeSentence(string sentence)
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
        Invoke("SceneChangePause", 2f);
    }

    void SceneChangePause()
    {
        SceneManager.LoadScene("1");
    }
}
