using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPan_scene3_5 : MonoBehaviour
{

    public float speed;

    private Vector2 direction;

    public bool moveCamera;

    void Start()
    {
        moveCamera = true;
    }

    void Update()
    {
        GetInput();
        if (moveCamera)
        {
            Move();
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "cameraTrigger")
        {
            speed = 0;
        }
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.left;
    }

}