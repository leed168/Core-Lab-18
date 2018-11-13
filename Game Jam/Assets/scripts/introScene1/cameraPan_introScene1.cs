using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraPan_introScene1 : MonoBehaviour
{

    [SerializeField]
    private float speed;

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

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {
        direction = Vector2.down;
    }

}