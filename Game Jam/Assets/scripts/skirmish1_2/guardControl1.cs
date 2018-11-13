using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class guardControl1: MonoBehaviour 
{
    SpriteRenderer sr;
    Color old;

    public AudioSource fx0;
    public AudioSource fx1;
    public AudioSource fx2;
    public AudioSource fx3;
    public AudioSource fx4;
    public AudioSource fx5;
    public AudioSource fx6;
    public AudioSource fx7;
    public AudioSource fx8;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start () 
    {
        old = sr.color;

        fx0 = GetComponent<AudioSource>();
	}
	
	void Update () 
    {
		if (Input.GetKey(KeyCode.A))
        {
            transform.position = new Vector2(-7,-2);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector2(-5, -2);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = new Vector2(-3, -2);
        }
        if (Input.GetKey(KeyCode.F))
        {
            transform.position = new Vector2(-1, -2);
        }
        if (Input.GetKey(KeyCode.J))
        {
            transform.position = new Vector2(1, -2);
        }
        if (Input.GetKey(KeyCode.K))
        {
            transform.position = new Vector2(3, -2);
        }
        if (Input.GetKey(KeyCode.L))
        {
            transform.position = new Vector2(5, -2);
        }
        if (Input.GetKey(KeyCode.Semicolon))
        {
            transform.position = new Vector2(7, -2);
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "projectile")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx0.Play();
        }
        if (col.gameObject.tag == "projectile1")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx1.Play();
        }
        if (col.gameObject.tag == "projectile2")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx2.Play();
        }
        if (col.gameObject.tag == "projectile3")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx3.Play();
        }
        if (col.gameObject.tag == "projectile4")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx4.Play();
        }
        if (col.gameObject.tag == "projectile5")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx5.Play();
        }
        if (col.gameObject.tag == "projectile6")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx6.Play();
        }
        if (col.gameObject.tag == "projectile7")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx7.Play();
        }
        if (col.gameObject.tag == "projectile8")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            fx8.Play();
        }
        if (col.gameObject.tag == "lastProjectile")
        {
            SceneManager.LoadScene("skirmish1_2cutscene");
        }
    }

    IEnumerator Pressed()
    {
        sr.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(0.1f);
        sr.color = old;
    }

}
