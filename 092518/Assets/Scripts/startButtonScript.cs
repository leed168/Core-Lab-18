using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startButtonScript : MonoBehaviour
{

    public void startGame(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }
}