using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour {

    public float moveSpeed;
    public float turnSpeed;

	// Use this for initialization
	void Start () {
        moveSpeed = 50f;
        turnSpeed = 200f;
        // speed = 100f;
	}
	
	// Update is called once per frame
	void Update () {
        // two lines of code below do the same thing! forward is shorthand for (0,0,1)
        // transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        // transform.Translate(Vector3.up * Time.deltaTime * speed);

        // code for rotating object to "speed"
        // transform.Rotate(Vector3.up, speed * Time.deltaTime);

         //if (Input.GetKey(KeyCode.W)) {
         //    transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed);
         //}
         //if (Input.GetKey(KeyCode.A)) {
         //    transform.Rotate(Vector3.up, -turnSpeed * Time.deltaTime);
         //}
         //if (Input.GetKey(KeyCode.S)) {
         //    transform.Translate(Vector3.back * Time.deltaTime * moveSpeed);
         //}
         //if (Input.GetKey(KeyCode.D)) {
         //    transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime);
         //}

        // this sets the position equal to a new value instead of adding a vector3
        // transform.position = new Vector3(Mathf.PingPong(Time.time*speed, 3), transform.position.y, transform.position.z);

        // use lerping to move between a start and end position
        Vector3 start = new Vector3(1f, 3f, 5f);
        Vector3 end = new Vector3(8f, -2f, 4f);

        Vector3 moving = Vector3.Lerp(start, end, Mathf.PingPong(Time.time, 1));
        transform.position = moving;
	}
}
