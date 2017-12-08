using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    bool GameStarted = false;
    private int numberOfThrows = 0;

    // Use this for initialization
    void Start () {
        this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }

	
	// Update is called once per frame
	void Update () {
        if (numberOfThrows % 2 == 0)
        {
            if (Input.GetKeyDown(KeyCode.Space) && !GameStarted)
            {
                GameStarted = true;
                this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
                numberOfThrows++;
                print(numberOfThrows);
            }
        }

        else
        {
            if (Input.GetKeyDown(KeyCode.Space) && !GameStarted)
            {
                GameStarted = true;
                this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
                this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, 10f);
                numberOfThrows++;
                print(numberOfThrows);
            }
        }
      

    }
}
