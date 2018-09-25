using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcheck2 : MonoBehaviour
{
    [SerializeField] private RawImage check2Image;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            check2Image.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            check2Image.enabled = false;
        }
    }
}
