using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Demo : MonoBehaviour
{
    public Text outPut;
    void Start()
    {
        int a = 1;
        int b = 5;
        a += b;
        outPut.text = a.ToString();
    }

    void Update()
    {
        
    }
}
