using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThatsGameTrigger : MonoBehaviour 
{

    [SerializeField] private RawImage customImage;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Ball"))
        {
            customImage.enabled = true;
        }
    }

    void OnTriggerExit(Collider2D other)
    {
        if(other.CompareTag("Ball"))
        {
            customImage.enabled = false;
        }
    }
}