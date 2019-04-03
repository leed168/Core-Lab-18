using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class startCONTROLS : MonoBehaviour
{
    public Animator FadeOut_Black;

    public void NextScene()
    {
        if (Input.GetMouseButtonUp(0))
        {
            FadeOut_Black.SetBool("FadeOut", true);
            Invoke("ControlScene", 0.5f);
        }
    }

    void ControlScene()
    {
        SceneManager.LoadScene("CONTROLS");
    }
}
