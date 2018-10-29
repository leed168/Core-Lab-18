using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howToPlayReturn : MonoBehaviour 
{

    [SerializeField] private string loadlevel;

	void Start () 
    {
		
	}
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SceneManager.LoadScene(loadlevel);
        }
    }
}
