﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCutscene_scene2_9 : MonoBehaviour
{
    float speed = 1f;

    private Vector2 direction;

    private Animator animator;

    void Start()
    {
        StartCoroutine(waiter());
        //animator = GetComponent<Animator>();

    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "trigger")
        {
            speed = 0;
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0);
        direction = Vector2.right;

    }

}
