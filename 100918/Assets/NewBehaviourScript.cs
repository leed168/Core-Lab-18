using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {

    public float height = 5f;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        RaycastHit hit;

        Debug.DrawRay(transform.position, Vector3.down * 5, Color.green);

        if (Physics.Raycast(transform.position, Vector3.down, out hit, height))
        {
            Debug.Log(hit.collider.tag);
            if (hit.collider.tag == "ground")
            {
                GetComponent<MeshRenderer>().material.color = Color.blue;
            }
        }
	}
}
