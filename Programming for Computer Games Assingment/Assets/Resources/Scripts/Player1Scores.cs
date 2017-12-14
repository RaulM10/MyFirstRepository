using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Scores : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    bool gameStarted = false;
    public Text Player1NetScore;
    public static int Player1Goals;
    int RandNum;
    private GameObject ball;
    
   
    // Use this for initialization
    void Start()
    {
        Player1Goals = 0;
        Player1NetScore.text = "Player 1: " + Player1Goals;
        ball = GameObject.Find("Ball");
        RandNum = Random.Range(0, 2);

    }

    // Update is called once per frame
    void Update()
    {
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

        if (Player1Goals == 10)
        {
            levelManager.LoadNewScene();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RandNum = Random.Range(0, 2);
        Player1Goals++;
        Player1NetScore.text = "Player 1: " + Player1Goals;
        ball.transform.position = new Vector3(0, 0, -0.5f);
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameStarted = false;
    }

    public void AddPoints(int Amount)
    {
        Player1Goals = Player1Goals + Amount;
        Player1NetScore.text = "Player 1: " + Player1Goals;
    }
}

