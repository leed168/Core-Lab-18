using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class keyScript : MonoBehaviour
{
    bool haveKey;

    void Start()
    { 
        haveKey = false;
    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "key")
        { 
            haveKey = true;
            Debug.Log("have key");
            Destroy(col.gameObject);
        }

        if (haveKey == true)
        {
            if (col.gameObject.tag == "door")
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
