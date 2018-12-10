using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTrigger_universal : MonoBehaviour
{
    public string loadLevelName;

    public int waitSeconds;

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "sceneTrigger")
    //    {
    //        fadeToLevel(1);
    //    }
    //}

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "sceneTrigger")
        {
            fadeToLevel(1);
        }
    }

    public void fadeToLevel(int levelIndex)
    {
        StartCoroutine(LoadAfterDelay(loadLevelName));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        //option to wait seconds before moving scenes
        yield return new WaitForSeconds(waitSeconds);
        SceneManager.LoadScene(levelName);
    }
}
