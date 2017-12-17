using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Player2Scores : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    bool gameStarted = false;
    public Text Player2NetScores;
    public Text Player2FinalScore;
    int ToBegin;
    public static int Player2Goals = 0;
    int RandNum;
    private GameObject ball;
    private string SceneName;

    // Use this for initialization
    void Start () {
        ToBegin = 0;
        Player2NetScores.text = "Player 2: " + ToBegin;
        ball = GameObject.Find("Ball");
        SceneName = SceneManager.GetActiveScene().name;
        
        
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
            Player2FinalScore.text = "Player 2 Final Score is " + Player2Goals;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        RandNum = Random.Range(0, 2);
        Player2Goals++;
        ToBegin++;
        Player2NetScores.text = "Player 2: " + ToBegin;
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
        Player2Goals = Player2Goals + Amount;
        Player2NetScores.text = "Player 2: " + ToBegin;
    }

}

