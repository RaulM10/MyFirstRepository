using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public Paddle paddle;
    Vector3 PaddleBallPosDiff;
    bool GameStarted = false;
	// Use this for initialization
	void Start () {

        PaddleBallPosDiff = this.transform.position - paddle.transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        if (!GameStarted)
        {
            this.transform.position = paddle.transform.position + PaddleBallPosDiff;
        }

        if(Input.GetMouseButtonDown(0) && !GameStarted)
        {
            GameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }



    }
}
