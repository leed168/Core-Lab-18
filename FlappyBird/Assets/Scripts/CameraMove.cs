using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
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
        // tried to make camera stop when dead
        //if (GameObject.FindGameObjectWithTag("Player") == null)
        //{
        //    direction = Vector2.zero;
        //}
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    private void GetInput()
    {

        direction = Vector2.right;

    }

}
