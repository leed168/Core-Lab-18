using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    private Rigidbody rb;

    public int speed = 20;

    public int jumpForce = 800;

    public float rotSpeed = 3;

    private Vector2 rotation = Vector2.zero;

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        Cursor.visible = false;
    }

    void Update()
    {
        rotation.y += Input.GetAxis("Mouse X");
        rotation.x -= Input.GetAxis("Mouse Y");
        transform.eulerAngles = rotation * rotSpeed;

        Vector3 move = Input.GetAxis("Vertical") * transform.forward * speed;
        Vector3 strafe = Input.GetAxis("Horizontal") * transform.right * speed;
        rb.velocity = move;

        //float xSpeed = Input.GetAxis("Horizontal") * speed;
        //float zSpeed = Input.GetAxis("Vertical") * speed;
        //rb.velocity = new Vector3(xSpeed, rb.velocity.y, zSpeed);

        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(new Vector3(0, jumpForce, 0));
        }
    }
}
