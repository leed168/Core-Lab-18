using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class autoScene_skirmish1_start : MonoBehaviour
{

    private void Start()
    {
        StartCoroutine(LoadAfterDelay("skirmish1_1"));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene(levelName);
    }

}
