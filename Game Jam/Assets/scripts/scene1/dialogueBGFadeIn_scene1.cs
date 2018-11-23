using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dialogueBGFadeIn_scene1 : MonoBehaviour
{
    public Animator animator;

    public string loadlevel;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "dialogueTrigger")
        {
            fadeIn(1);
        }
    }

    public void fadeIn(int levelIndex)
    {
        animator.SetTrigger("fadeIn");
    }

}
