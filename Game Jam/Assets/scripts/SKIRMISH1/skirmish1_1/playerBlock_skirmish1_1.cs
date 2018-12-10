using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerBlock_skirmish1_1 : MonoBehaviour 
{
    public Sprite block;

    public Sprite normal;
    
    void Awake () 
    {
        //GetComponent<SpriteRenderer>().sprite = block;
        //GetComponent<SpriteRenderer>().sprite = normal;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "projectile")
        {
            Destroy(col.gameObject);
            StartCoroutine(blockAnimation());
            //fx0.Play();
        }
    }

    IEnumerator blockAnimation()
    {
        GetComponent<SpriteRenderer>().sprite = block;
        yield return new WaitForSeconds(0.1f);
        GetComponent<SpriteRenderer>().sprite = normal;
    }
}
