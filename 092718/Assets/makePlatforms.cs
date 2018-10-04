using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePlatforms : MonoBehaviour {

    public GameObject platform;
    float timer = 0;

    GameObject[] platforms;

	void Start () 
    {

	}
	
	void Update () 
    {
        timer += Time.deltaTime;

        if (timer >= 2)
        {
            GameObject clone = Instantiate(platform, (new Vector2(Random.Range(-8f, 8f), 6f)), Quaternion.identity);
            clone.transform.localScale = new Vector2(Random.Range(2f, 8f), 1f);
            timer = 0;
        }

        platforms = GameObject.FindGameObjectsWithTag("platform");

        foreach(GameObject p in platforms)
        {
            p.transform.localPosition = new Vector2(p.transform.localPosition.x, p.transform.localPosition.y - 0.1f);
          
            if (p.transform.localPosition.y < -6)
            {
                Destroy(p);
            }
        }
    }
}
