using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FallDeathTrigger : MonoBehaviour
{
    public Animator DeathFadeBlack;

    public string SceneRestart;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Invoke("RestartFadeOut", 1.5f);
            Invoke("RestartScene", 2);

        }
    }

    void RestartScene()
    {
        SceneManager.LoadScene(SceneRestart);
    }

    void RestartFadeOut()
    {
        DeathFadeBlack.SetBool("FadeOut", true);
    }
}
