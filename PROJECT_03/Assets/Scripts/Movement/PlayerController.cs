using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float horizontal;
    public float speed = 5.5f;

    public bool grounded;
    //public float jump;

    //public float jumpForce;
    [Range(1, 10)]
    public float JumpVelocity;

    public bool facingRight = false;

    public LayerMask whatIsGround;
    public float groundRadius;
    public Transform groundPoint;

    Rigidbody2D rb;
    Animator an;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        an = GetComponent<Animator>();
    }

    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        //jump = Input.GetAxisRaw("Jump");
    }

    void FixedUpdate()
    {
        grounded = Physics2D.OverlapCircle(groundPoint.position,groundRadius,whatIsGround);
        Move();
        Jump();
        Flip();

        an.SetFloat("Speed", Mathf.Abs(rb.velocity.x));
        an.SetBool("Grounded", grounded);
    }

    void Move()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    void Jump()
    {
        if(grounded)
            if (Input.GetButtonDown("Jump"))
            {
                GetComponent<Rigidbody2D>().velocity = Vector2.up * JumpVelocity;
            }
    }

    void Flip()
    {
        if((horizontal<0 && facingRight == true) || (horizontal>0 && facingRight == false))
        {
            facingRight = !facingRight;
            Vector3 theScale = transform.localScale;
            theScale.x *= -1;
            transform.localScale = theScale;
        }
    }

   
}
