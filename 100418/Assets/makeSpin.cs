﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeSpin : MonoBehaviour 
{

    Animator anim;

	void Start () 
    {
        anim = GetComponent<Animator>();
	}
	
	void Update ()
    {
		
	}

    private void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("collision");
        anim.SetTrigger("doSpin");
    }
}
