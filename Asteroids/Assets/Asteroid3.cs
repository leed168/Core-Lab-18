using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid3 : MonoBehaviour 
{

    public float maxPush;
    public float maxSpin;
    public Rigidbody2D rb;

	void Start () 
    {
        Vector2 push = new Vector2(Random.Range(-maxPush, maxPush), Random.Range(-maxPush, maxPush));

        float spin = Random.Range(-maxSpin, maxSpin);

        rb.AddForce(push);
        rb.AddTorque(spin);
	}
	
	void Update () 
    {

        Vector2 newPos = transform.position;
        if (transform.position.y > 6.53f)
        {
            newPos.y = -6.53f;
        }
        if (transform.position.y < -6.53f)
        {
            newPos.y = 6.53f;
        }
        if (transform.position.x > 8.2f)
        {
            newPos.x = -8.2f;
        }
        if (transform.position.x < -8.2f)
        {
            newPos.x = 8.2f;
        }
        transform.position = newPos;
	}
}
