using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyMove : MonoBehaviour 
{

    [SerializeField]
    private float speed;

    private Vector2 direction;

    void Start()
    {

    }

    void Update()
    {
        GetInput();
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {

        direction = Vector2.right;

        if (Input.GetKey(KeyCode.Space))
        {
            direction += Vector2.up;
        }
        else
        {
            direction += Vector2.down;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(GameObject.FindWithTag("Player"));
    }

}
