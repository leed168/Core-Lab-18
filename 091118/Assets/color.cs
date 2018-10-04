using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    private void OnCollisionEnter(Collision other){
        Debug.Log(other);
        if (other.gameObject.tag == "sphere") {

        }

    }
         
    }

void physics() []