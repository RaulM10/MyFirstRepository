using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoseScript : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    public Text Lives;
    int lives = 3;
    GameObject ballPrefab;
    Vector3 initialBallPos;

    GameObject paddle;
    Vector3 initialPaddlePos;

    // Use this for initialization
    void Start () {
        Lives.text = "Lives = " + lives;
        ballPrefab = Resources.Load("Prefabs/ball") as GameObject;
        initialBallPos = ballPrefab.transform.position;

        paddle = GameObject.Find("Paddle");
        initialPaddlePos = paddle.transform.position;
        
    }
	
	// Update is called once per frame
	void Update () {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        lives--;
        if (lives > 0)
        {
            Lives.text = "Lives = " + lives;
            Destroy(collision.gameObject);
            paddle.transform.position = initialPaddlePos;
            Instantiate(ballPrefab, initialBallPos, Quaternion.identity);
        }
        print("Collision");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }

}
