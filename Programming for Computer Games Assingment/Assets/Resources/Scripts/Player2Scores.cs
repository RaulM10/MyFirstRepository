using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Scores : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    bool gameStarted = false;
    public Text Player2NetScores;
    public static int Player2Goals;
    int RandNum;
    private GameObject ball;

    // Use this for initialization
    void Start () {
        Player2Goals = 0;
        Player2NetScores.text = "Player 2: " + Player2Goals;
        ball = GameObject.Find("Ball");
        RandNum = Random.Range(0, 2);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Space) && RandNum % 2 == 0 && !gameStarted)
        {
            gameStarted = true;
            ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }

        else if (Input.GetKeyDown(KeyCode.Space) && RandNum != 0 && !gameStarted)
        {
            gameStarted = true;
            ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Dynamic;
            ball.GetComponent<Rigidbody2D>().velocity = new Vector2(-2f, 10f);
        }

        if (Player2Goals == 10)
        {
            levelManager.LoadNewScene();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    { 
        Player2Goals++;
        Player2NetScores.text = "Player 2: " + Player2Goals;
        ball.transform.position = new Vector3(0, 0, -0.5f);
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameStarted = false;
    }

    public void AddPoints(int Amount)
    {
        Player2Goals = Player2Goals + Amount;
        Player2NetScores.text = "Player 2: " + Player2Goals;
    }
 }

