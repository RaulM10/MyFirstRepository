using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Paddle : MonoBehaviour {

    float speed = 30f;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () { 
   
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;

            float KeyboardPaddle = (transform.position.y / Screen.height * 16) - 8;
       
            Vector3 KeyboardBorder = new Vector3(this.transform.position.x, KeyboardPaddle, this.transform.position.z);

            KeyboardBorder.y = Mathf.Clamp(transform.position.y, -4.5548f, 4.5548f);

            transform.position = KeyboardBorder;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;

            float KeyboardPaddle = (transform.position.y / Screen.height * 16) - 8;
           
            Vector3 KeyboardBorder = new Vector3(this.transform.position.x, KeyboardPaddle, this.transform.position.z);

            KeyboardBorder.y = Mathf.Clamp(transform.position.y, -4.5548f, 4.5548f);

            transform.position = KeyboardBorder;
        }


    }
}
