using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class skuldGuard_skirmish1_1 : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 direction;

    private Animator animator;

    SpriteRenderer sr;
    Color old;

    //public Sprite block;
    //public Sprite normal;

    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        old = sr.color;
        //StartCoroutine(waiter());
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        //GetInput();

        //Move();
    }

    //public void Move()
    //{
    //    transform.Translate(direction * speed * Time.deltaTime);
    //}

    void OnTriggerEnter2D(Collider2D col)
    {
        //if (col.gameObject.tag == "sceneTrigger")
        //{
        //    speed = 0;
        //}
        if (col.gameObject.tag == "urd_projectile")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            //fx0.Play();
        }
        //if (col.gameObject.tag == "lastProjectile")
        //{
        //    SceneManager.LoadScene("skirmish1_1cutscene");
        //}
    }

    IEnumerator Pressed()
    {
        sr.color = new Color(255, 0, 0);
        //GetComponent<SpriteRenderer>().sprite = block;
        yield return new WaitForSeconds(0.2f);
        sr.color = old;
        //GetComponent<SpriteRenderer>().sprite = normal;
    }
}
