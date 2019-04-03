using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controlsSTART : MonoBehaviour
{
    public Animator FadeOut_Black;

    void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            FadeOut_Black.SetBool("FadeOut", true);
            Invoke("ControlScene", 0.5f);
        }
    }

    void ControlScene()
    {
        SceneManager.LoadScene("START");
    }
}
