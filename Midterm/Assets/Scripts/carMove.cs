using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMove : MonoBehaviour 
{
    [SerializeField]
    private float speed;
    private Vector2 direction;

    void Start()
    {

    }

    void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
        direction = Vector2.up;
    }

    //private void GetInput()
    //{
    //    direction = Vector2.up;
    //}
}
