using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatternRotate_Opposite : MonoBehaviour
{
    private float speed = -100;

    void Update()
    {
        //speed += Mathf.Sin(Time.time * 2) / 20;

        speed += Mathf.Sin(Time.time * -2) * 5;

        transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        //Debug.Log("pattern speed" + speed);
    }
}
