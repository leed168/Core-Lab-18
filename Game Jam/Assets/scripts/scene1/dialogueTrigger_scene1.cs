using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger_scene1 : MonoBehaviour
{
    public dialogue dialogue;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            triggerDialogue();
        }
    }

    public void triggerDialogue()
    {
        FindObjectOfType<dialogueManager_scene1>().startDialogue(dialogue);
    }
}
