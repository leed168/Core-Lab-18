using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinBounce : MonoBehaviour {

	void Start () 
    {
		
	}
	
	void Update () 
    {
        transform.Rotate(Vector2.right, Time.deltaTime * 100);
        transform.Translate(Vector2.left * (Mathf.Sin(Time.time*5)/100));
	}
}
