using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisablePlayerTemp_Scene1 : MonoBehaviour
{
    public GameObject Player;

    void Start()
    {
        Player.GetComponent<PlayerController>().enabled = false;
        Player.GetComponent<Animator>().enabled = false;
    }
}