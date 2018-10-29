using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class howToPlay : MonoBehaviour 
{

    [SerializeField] private string loadlevel;

	void Start () 
    {
		
	}
	
	void Update () 
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            SceneManager.LoadScene(loadlevel);
        }
    }
}
