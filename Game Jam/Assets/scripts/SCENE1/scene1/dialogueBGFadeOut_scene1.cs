﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dialogueBGFadeOut_scene1 : MonoBehaviour
{
    public Animator animator;

    public string loadlevel;

    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            fadeIn(1);
        }
    }

    public void fadeIn(int levelIndex)
    {
        animator.SetTrigger("fadeOut");
    }

}
