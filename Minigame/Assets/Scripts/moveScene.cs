﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class moveScene : MonoBehaviour 
{
    [SerializeField]private string loadlevel;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            SceneManager.LoadScene(loadlevel);
        }
    }
}