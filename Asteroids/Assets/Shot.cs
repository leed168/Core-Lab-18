﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(GameObject.FindWithTag("Asteroid"));
    }
}
