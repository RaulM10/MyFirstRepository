using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player1Scores : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    bool gameStarted = false;
    public Text Player1NetScore;
    public Text Player1FinalScore;
    int ToBegin;
    public static int Player1Goals = 0;
    int RandNum;
    private GameObject ball;
    private string SceneName;



    // Use this for initialization
    void Start()
    {
        ToBegin = 0;
        Player1NetScore.text = "Player 1: " + ToBegin;
        ball = GameObject.Find("Ball");
        SceneName = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && RandNum / 2 == 0 && !gameStarted)
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

        if (ToBegin == 10 && SceneName == "Level_01")
        {
            levelManager.LoadNewSceneIndex();
        }

        else if (ToBegin == 20 && SceneName == "Level_02")
        {
            
            levelManager.LoadNewSceneIndex();
        }

        else if (ToBegin == 50 && SceneName == "Level_03")
        {
            levelManager.LoadNewSceneIndex();
        }

        if (SceneName == "EndScreen")
        {
            Player1FinalScore.text = "Player 1 Final Score is " + Player1Goals;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RandNum = UnityEngine.Random.Range(0, 2);
        ToBegin++;
        Player1Goals++;
        Player1NetScore.text = "Player 1: " + ToBegin;
        ball.transform.position = new Vector3(0, 0, -0.5f);
        ball.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        gameStarted = false;
    }

    public void AddPoints(int Amount)
    {
        ToBegin = ToBegin + Amount;
        Player1Goals = Player1Goals + Amount;
        Player1NetScore.text = "Player 1: " + ToBegin;
    }

}

