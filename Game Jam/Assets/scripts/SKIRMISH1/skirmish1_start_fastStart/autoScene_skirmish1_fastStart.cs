using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class autoScene_skirmish1_fastStart : MonoBehaviour
{
    public string nextScene;

    private void Start()
    {
        StartCoroutine(LoadAfterDelay(nextScene));
    }

    IEnumerator LoadAfterDelay(string levelName)
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(levelName);
    }

}