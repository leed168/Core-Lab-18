using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class autoScene_scene3_7 : MonoBehaviour {

    private void Start()
    {
        StartCoroutine(LoadAfterDelay("skirmish1_start"));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(levelName);
    }

}
