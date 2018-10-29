using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class startGame : MonoBehaviour 
{

    [SerializeField] private string loadlevel;

	void Start () 
    {
		
	}
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene(loadlevel);
        }
    }
}
