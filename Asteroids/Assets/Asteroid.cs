using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : MonoBehaviour
{

    public float maxPush;
    public float maxSpin;
    public Rigidbody2D rb;

    public int health = 100;

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    void Start()
    {
        Vector2 push = new Vector2(Random.Range(-maxPush, maxPush), Random.Range(-maxPush, maxPush));

        float spin = Random.Range(-maxSpin, maxSpin);

        rb.AddForce(push);
        rb.AddTorque(spin);
    }

    void Update()
    {

        Vector2 newPos = transform.position;
        if (transform.position.y > 5.5f)
        {
            newPos.y = -5.5f;
        }
        if (transform.position.y < -5.5f)
        {
            newPos.y = 5.5f;
        }
        if (transform.position.x > 7.25f)
        {
            newPos.x = -7.25f;
        }
        if (transform.position.x < -7.25f)
        {
            newPos.x = 7.25f;
        }
        transform.position = newPos;
    }

    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
    }

}
