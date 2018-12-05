using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerCutscene_scene1_4_1: MonoBehaviour
{
    float speed = 1f;

    private Vector2 direction;

    private Animator animator;

    void Start()
    {
        StartCoroutine(waiter());
        animator = GetComponent<Animator>();

    }

    void Update()
    {
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
            fadeToLevel(1);
        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(0);
        direction = Vector2.down;

    }

    public void fadeToLevel(int levelIndex)
    {
        StartCoroutine(LoadAfterDelay("scene1_5"));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(levelName);
    }

}
