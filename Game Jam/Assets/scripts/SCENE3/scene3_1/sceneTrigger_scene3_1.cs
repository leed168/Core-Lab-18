using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneTrigger_scene3_1 : MonoBehaviour
{
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
        StartCoroutine(LoadAfterDelay("scene3_2"));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        //option to wait seconds before moving scenes
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(levelName);
    }
}
