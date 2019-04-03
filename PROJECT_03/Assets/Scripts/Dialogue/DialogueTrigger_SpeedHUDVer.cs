using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_SpeedHUDVer : MonoBehaviour
{
    public Dialogue dialogue;

    void OnTriggerEnter2D(Collider2D col)     {         if (col.gameObject.tag == "Player")         {             TriggerDialogue();
            Destroy(gameObject);         }     }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager_SpeedHUDVer>().StartDialogue(dialogue);
    }
}
