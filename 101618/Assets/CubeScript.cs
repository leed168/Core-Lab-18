﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour 
{

    public GameObject sphere;

	void Start () 
    {

	}
	
	void Update () 
    {
		if (Input.GetKeyDown("f"))
        {
            StartCoroutine("Fade");
        }
        StartCoroutine("SphereCheck");
	}

    IEnumerator SphereCheck()
    {
        float dist = Vector3.Distance(transform.position, sphere.transform.position);
        if (dist <5f)
        {
            Debug.Log("Fuck.");
        }
        else
        {
            Debug.Log("fuck :)");
        }
        yield return new WaitForSeconds(0.1f);
    }

    IEnumerator Fade ()
    {
        for (float i = 1f; i >= 0; i -= 0.01f)
        {
            Color c = GetComponent<Renderer>().material.color;
            c.a = i;
            GetComponent<Renderer>().material.color = c;
            yield return null;
        }
    }
}
