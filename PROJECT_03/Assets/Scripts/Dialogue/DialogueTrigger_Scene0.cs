using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_Scene0 : MonoBehaviour
{
    public Dialogue dialogue;

    void Start()
    {
        Invoke("TriggerDialogue", 14);
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager_Scene0>().StartDialogue(dialogue);
    }
}
