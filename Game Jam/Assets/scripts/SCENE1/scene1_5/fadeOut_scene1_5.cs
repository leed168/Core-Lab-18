using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeOut_scene1_5 : MonoBehaviour 
{
    public Animator animator;

    public string nextScene;

    public float waitForSeconds;

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            fadeToLevel(1);
        }
    }

        public void fadeToLevel (int levelIndex)
    {
        animator.SetTrigger("fadeOut");
        StartCoroutine(LoadAfterDelay(nextScene));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(waitForSeconds);
        SceneManager.LoadScene(levelName);
    }
}
