using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow_scene2 : MonoBehaviour
{
    public Transform target;

    Camera theCamera;

    void Start()
    {
        theCamera = GetComponent<Camera>();
    }

    void Update()
    {
        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, 0.05f) + new Vector3(0, 0, -10);
        }
    }
}
