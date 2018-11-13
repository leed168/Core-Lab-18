using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cutSceneFadeOut : MonoBehaviour 
{
    public Animator animator;

    public string loadlevel;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sceneTrigger")
        {
            fadeToLevel(1);
        }
    }

        public void fadeToLevel (int levelIndex)
    {
        animator.SetTrigger("fadeOut");
        StartCoroutine(LoadAfterDelay("skirmish1_1"));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(levelName);
    }
}
