using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charAnimation : MonoBehaviour 
{

    SpriteRenderer sr;

    public Sprite lookRight;
    public Sprite lookLeft;
    public Sprite lookFront;

    Rigidbody2D rb;

    public float moveSpeed = 2f;

	void Start () 
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	void Update () 
    {
		// if right
        if(Input.GetKey(KeyCode.RightArrow))
        {
            sr.sprite = lookRight;
            rb.AddForce(transform.right * moveSpeed, ForceMode2D.Impulse);
        }
        // if left
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            sr.sprite = lookLeft;
            rb.AddForce(transform.right * -moveSpeed, ForceMode2D.Impulse);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(transform.up * moveSpeed, ForceMode2D.Impulse);
        }

        else
        {
            sr.sprite = lookFront;
        }

	}
}
