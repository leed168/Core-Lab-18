using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class autoScene_UNI : MonoBehaviour
{
    public string nextScene;

    public float waitForSeconds;

    private void Start()
    {
        StartCoroutine(LoadAfterDelay(nextScene));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(waitForSeconds);
        SceneManager.LoadScene(levelName);
    }

}
