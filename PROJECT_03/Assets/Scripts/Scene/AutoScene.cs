﻿using System.Collections; using System.Collections.Generic; using UnityEngine; using UnityEngine.SceneManagement;  public class AutoScene : MonoBehaviour
{     public string NextScene;      private void Start()     {         StartCoroutine(LoadAfterDelay(NextScene));     }      IEnumerator LoadAfterDelay(string levelName)     {         yield return new WaitForSeconds(13);         SceneManager.LoadScene(levelName);     }  }