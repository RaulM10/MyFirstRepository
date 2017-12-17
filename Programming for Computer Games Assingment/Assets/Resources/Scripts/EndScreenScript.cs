using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndScreenScript : MonoBehaviour {

    public Player1Scores player1Score;
    public Player2Scores player2Score;
    private int Player1FnlScore;
    private int Player2FnlScore;
    public Text Player1FinalScore;
    public Text Player2FinalScore;
    public Text PlayerWinner;

    // Use this for initialization
    void Start () {
        Player1FnlScore = Player1Scores.Player1Goals;
        Player2FnlScore = Player2Scores.Player2Goals;
        Player2FinalScore.text = "Final Score of Player 2 is " + Player2FnlScore;
        Player1FinalScore.text = "Final Score of Player 1 is " + Player1FnlScore;
	}
	
	// Update is called once per frame
	void Update () {
        if (Player1FnlScore == 80)
        {
            PlayerWinner.text = "Player 1 is the Winner!!!";
        }
        else if (Player2FnlScore == 80)
        {
            PlayerWinner.text = "Player 2 is the Winner!!!";
        }
	}
}
