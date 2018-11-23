using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class fadeOut_scene1_2 : MonoBehaviour
{
    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    if (col.gameObject.tag == "sceneTrigger")
    //    {
    //        fadeToLevel(1);
    //    }
    //}

    void Update()
    {
        if (Input.GetKey(KeyCode.X))
        {
            fadeToLevel(1);
        }
    }

    public void fadeToLevel(int levelIndex)
    {
        StartCoroutine(LoadAfterDelay("scene1_3"));
    }


    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(levelName);
    }
}
