using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    float speed = 0.5f;

    private SpriteRenderer sp;

    private void Start()
    {
        sp = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        sp.color = Color.Lerp(Color.yellow, Color.magenta, Mathf.PingPong(Time.time * speed, 1));
    }
}
