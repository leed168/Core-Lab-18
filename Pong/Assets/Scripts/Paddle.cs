using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    float speed;
    float height;

    string input;
    public bool isRight;

	// Use this for initialization
	void Start () {
        height = transform.localScale.y;
        speed = 7f;
	}

    public void Init(bool isRightPaddle)
    {
        isRight = isRightPaddle;

        Vector2 pos = Vector2.zero;
        if (isRightPaddle)
        {
            pos = new Vector2(GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x;

            input = "PaddleRight";
        }
        else
        {
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x;

            input = "PaddleLeft";
        }

        transform.position = pos;

        transform.name = input;
    }
	
	// Update is called once per frame
	void Update () {
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        transform.Translate(move * Vector2.up);
	}
}
