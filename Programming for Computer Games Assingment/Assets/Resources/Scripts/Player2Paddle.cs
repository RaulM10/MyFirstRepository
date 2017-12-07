using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float MousePosUnits = (Input.mousePosition.y / Screen.height * 16) - 8;

        Vector3 NewPaddlePos = new Vector3(this.transform.position.x, MousePosUnits, this.transform.position.z);

        NewPaddlePos.y = Mathf.Clamp(MousePosUnits, -4.5548f, 4.5548f);

        this.transform.position = NewPaddlePos;

    }
}
