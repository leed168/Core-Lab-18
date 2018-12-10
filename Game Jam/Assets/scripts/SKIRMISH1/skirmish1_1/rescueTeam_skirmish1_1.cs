using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rescueTeam_skirmish1_1 : MonoBehaviour
{
    SpriteRenderer sr;
    Color old;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        old = sr.color;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "projectile")
        {
            StartCoroutine(Pressed());
            //fx0.Play();
        }
    }



    IEnumerator Pressed()
    {
        sr.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(0.1f);
        sr.color = old;
    }
}
