using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIcheck1 : MonoBehaviour
{
    [SerializeField] private RawImage check1Image;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            check1Image.enabled = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            check1Image.enabled = false;
        }
    }
}
