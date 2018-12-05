using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class playerMove_skirmish1_1 : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Vector2 direction;

    private Animator animator;

    SpriteRenderer sr;
    Color old;

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
        StartCoroutine(waiter());

        Move();
    }

    public void Move()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sceneTrigger")
        {
            speed = 0;
        }
        if (col.gameObject.tag == "projectile")
        {
            Destroy(col.gameObject);
            StartCoroutine(Pressed());
            //fx0.Play();
        }
        if (col.gameObject.tag == "lastProjectile")
        {
            SceneManager.LoadScene("skirmish1_1cutscene");
        }
    }

    private void GetInput()
    {

        direction = Vector2.zero;

        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector2.up;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector2.left;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector2.down;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector2.right;
        }
    }

        IEnumerator waiter()
    {
        yield return new WaitForSeconds(0);
        GetInput();
    }

    IEnumerator Pressed()
    {
        sr.color = new Color(255, 0, 0);
        yield return new WaitForSeconds(0.1f);
        sr.color = old;
    }
}
