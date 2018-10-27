using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField]
    private float speed;

    public float rotateSpeed;
    public GameObject shot;
    public float shotSpeed;
    public int damage = 40;

    private Vector2 direction;

    void Start()
    {

    }

    void Update()
    {
        GetInput();
        Move();
        RotateMove();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        Vector2 newPos = transform.position;
        if (transform.position.y > 5.5f)
        {
            newPos.y = -5.5f;
        }
        if (transform.position.y < -5.5f)
        {
            newPos.y = 5.5f;
        }
        if (transform.position.x > 7)
        {
            newPos.x = -7;
        }
        if (transform.position.x < -7)
        {
            newPos.x = 7;
        }
        transform.position = newPos;
    }

    void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void GetInput()
    {

        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
    }

    void RotateMove ()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(Vector3.forward * rotateSpeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(Vector3.back * rotateSpeed);
        }
    }

    void Shoot ()
    {
        GameObject newShot = Instantiate(shot, transform.position, transform.rotation);
        newShot.GetComponent<Rigidbody2D>().AddRelativeForce(Vector2.up * shotSpeed);
        Destroy(newShot, 2f);

        //if (newShot)
        //{
        //    Asteroid asteroid = newShot.transform.GetComponent<Asteroid>();
        //    if (asteroid != null)
        //    {
        //        asteroid.TakeDamage(damage);
        //    }

        //    //Instantiate(Quaternion.identity);

        //}
    }


}
