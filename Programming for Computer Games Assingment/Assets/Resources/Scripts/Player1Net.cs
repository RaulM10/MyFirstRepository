using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1Net : MonoBehaviour {

    LevelManager levelManager = new LevelManager();
    Player2Net player2Net = new Player2Net();
    public int Player1Goals = 0;
    public Text Player1Score;

	// Use this for initialization
	void Start () {
        Player1Score.text = "Player 1: " + Player1Goals;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player2Net.Player2Goals++;
        player2Net.Player2Score.text = "Player 2: " + player2Net.Player2Goals;
        levelManager.ReloadLevel();
    }
}
