using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class arrowFlare_introScene1 : MonoBehaviour
{
    public Animator animator;

    public string loadlevel;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            fadeIn(1);
        }
    }

    public void fadeIn(int levelIndex)
    {
        animator.SetTrigger("flareTrigger");
    }

}
