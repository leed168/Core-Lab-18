using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carBehavior : MonoBehaviour 
{

    [SerializeField] private Text loseText;

    public AudioSource crashSound;

    private void Start()
    {
        crashSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            loseText.enabled = true;
            crashSound.enabled = true;
        }
    }
}