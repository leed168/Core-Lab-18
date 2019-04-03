using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGAME : MonoBehaviour
{
    public Animator FadeOut_Black;

    public void NextScene()
    {
        if (Input.GetMouseButtonUp(0))
        {
            FadeOut_Black.SetBool("FadeOut", true);
            Invoke("ControlScene", 2f);
        }
    }

    void ControlScene()
    {
        SceneManager.LoadScene("0");
    }
}
