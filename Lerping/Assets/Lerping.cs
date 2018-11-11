using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lerping : MonoBehaviour
{
    Color lerpedColor = Color.red;

    void Update()
    {
        lerpedColor = Color.Lerp(Color.red, Color.blue, Mathf.PingPong(Time.time, 1));
    }
}

