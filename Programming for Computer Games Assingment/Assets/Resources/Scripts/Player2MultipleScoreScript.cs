using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player2MultipleScoreScript : MonoBehaviour {

 
    private Player2Scores player2Score;
    

    // Use this for initialization
    void Start ()
    {
        player2Score = GetComponent<Player2Scores>();
	}
	
	// Update is called once per frame
	void Update () {
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player2Score.AddPoints(1);
    }
}
