using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour {

    public float moveSpeed;
    public float rotateSpeed;

	// Use this for initialization
	void Start () {
        moveSpeed = 25f;
        rotateSpeed = 110f;
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime, 0f, 0f);
        transform.Rotate(0f, rotateSpeed * Input.GetAxis("Horizontal") * Time.deltaTime, 0f);
    }
}
