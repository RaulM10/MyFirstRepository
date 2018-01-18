using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    public bool auto = false;
    GameObject ball;

	// Use this for initialization
	void Start () {
        ball = GameObject.Find("ball");
	}
	
	// Update is called once per frame
	void Update () {

        if (!auto)
        {
            float MousePosUnits = (Input.mousePosition.x / Screen.width * 16) - 8;

            Vector3 NewPaddlePos = new Vector3(MousePosUnits, this.transform.position.y, this.transform.position.z);

            NewPaddlePos.x = Mathf.Clamp(MousePosUnits, -7.36f, 7.36f);

            this.transform.position = NewPaddlePos;
        }

        else
        {
            Vector3 NewPaddlePos = new Vector3(ball.transform.position.x, this.transform.position.y, this.transform.position.z);

            this.transform.position = NewPaddlePos;
        }

    }
}
