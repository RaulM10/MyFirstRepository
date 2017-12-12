using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2Net : MonoBehaviour {

    Player1Net player1Net = new Player1Net();
    public int Player2Goals = 0;
    public Text Player2Score;

	// Use this for initialization
	void Start () {
        Player2Score.text = "Player 2: " + Player2Goals;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    { }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player1Net.Player1Goals++;
        player1Net.Player1Score.text = "Player 1: " + player1Net.Player1Goals; 
    }
}
