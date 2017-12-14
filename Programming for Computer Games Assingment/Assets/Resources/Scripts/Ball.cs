using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    bool gameStarted = false;
    int RandomNum;

    // Use this for initialization
    void Start() {
        this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        RandomNum = Random.Range(0, 2);
    }


    // Update is called once per frame
    void Update() { 

        if (Input.GetKeyDown(KeyCode.Space) && RandomNum % 2 == 0 && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }

        else if (Input.GetKeyDown(KeyCode.Space) && RandomNum != 0 && !gameStarted)
        {
            gameStarted = true;
            this.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, 10f);
        }
    } 
}
       




