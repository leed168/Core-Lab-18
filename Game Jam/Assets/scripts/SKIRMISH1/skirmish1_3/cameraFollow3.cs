using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow3 : MonoBehaviour
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
            transform.position = Vector3.Lerp(transform.position, target.position, 0.01f) + new Vector3(0, 0.025f, -10);
        }
    }
}
