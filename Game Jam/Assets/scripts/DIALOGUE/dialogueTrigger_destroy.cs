﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTrigger_destroy : MonoBehaviour 
{

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }
}
