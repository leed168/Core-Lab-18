using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMove : MonoBehaviour 
{

    [SerializeField]
    private float speed;

    private Vector2 direction;

    public bool moveCamera;

	void Start () 
    {
        moveCamera = true;
	}
	
	void Update () 
    {
        GetInput();
        if (moveCamera)
        {
            Move();
        }
	}

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.up;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
    }

}
