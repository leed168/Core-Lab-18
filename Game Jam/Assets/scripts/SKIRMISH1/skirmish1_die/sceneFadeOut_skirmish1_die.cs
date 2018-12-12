using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneFadeOut_skirmish1_die : MonoBehaviour
{
    public Animator animator;

    public string nextScene;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sceneTrigger")
        {
            fadeToLevel(1);
        }
    }

    public void fadeToLevel(int levelIndex)
    {
        animator.SetTrigger("fadeOut");
        StartCoroutine(LoadAfterDelay(nextScene));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(levelName);
    }
}