using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AutoScene : MonoBehaviour 
{
    public float WaitForSeconds;

    private void Start()
    {
        StartCoroutine(LoadAfterDelay("Scene_1"));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(WaitForSeconds);
        SceneManager.LoadScene(levelName);
    }

}
