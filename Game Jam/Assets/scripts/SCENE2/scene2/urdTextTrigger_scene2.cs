using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class urdTextTrigger_scene2 : MonoBehaviour
{
    public Animator animator;

    public string loadlevel;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "dialogueTrigger")
        {
            fadeToLevel(1);
        }
    }

    public void fadeToLevel(int levelIndex)
    {
        animator.SetTrigger("fadeIn");
        //StartCoroutine(LoadAfterDelay("scene2"));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelName);
    }
}
