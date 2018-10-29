using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerCrash : MonoBehaviour 
{

    [SerializeField] private Image crashImage;


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Car"))
        {
            crashImage.enabled = true;
        }
    }

}
