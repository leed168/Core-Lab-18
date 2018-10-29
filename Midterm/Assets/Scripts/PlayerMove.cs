using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    private float speed;

    private Vector2 direction;

    public GameObject camera;

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

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(GameObject.FindWithTag("Player"));
        camera.GetComponent<cameraMove>().moveCamera = false;

    }

}
