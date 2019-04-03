using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger_Scene1Ver : MonoBehaviour
{
    public Dialogue dialogue;

    void Start()
    {
        Invoke("TriggerDialogue", 6.5f);
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<DialogueManager_Scene1_Start>().StartDialogue(dialogue);
    }
}
