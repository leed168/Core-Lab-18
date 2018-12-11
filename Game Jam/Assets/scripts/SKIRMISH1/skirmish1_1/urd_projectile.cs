using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class urd_projectile : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        StartCoroutine(waiter());
    }

    void Update()
    {

    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(1);
        rb.velocity = new Vector2(0, speed);
    }
}
