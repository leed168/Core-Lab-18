using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogueManager_scene1 : MonoBehaviour
{
    public Text nameText;
    public Text dialogueText;
    public float typeSpeed;

    public Animator animator;
    public Animator arrowAnimator;
    public Animator fallenGuardAnimator;

    private Queue<string> sentences;

    void Start()
    {
        sentences = new Queue<string>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            displayNextSentence();
        }
    }

    public void startDialogue(dialogue dialogue)
    {
        animator.SetBool("isOpen", true);

        nameText.text = dialogue.name;

        sentences.Clear();

        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        displayNextSentence();
    }

    public void displayNextSentence()
    {
        if (sentences.Count == 0)
        {
            endDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(typeSentence(sentence));

    }

    IEnumerator typeSentence(string sentence)
    {
        yield return new WaitForSeconds(0f);
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return new WaitForSeconds(typeSpeed);
        }
    }

    void endDialogue()
    {
        animator.SetBool("isOpen", false);
        arrowAnimator.SetBool("flare", true);
        fallenGuardAnimator.SetBool("shine", true);
        Debug.Log("End of conversation.");
    }

}
