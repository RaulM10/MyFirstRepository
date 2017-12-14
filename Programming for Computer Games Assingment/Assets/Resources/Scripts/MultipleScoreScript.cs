using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleScoreScript : MonoBehaviour {

    Player1Scores player1Score = new Player1Scores();
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player1Score.AddPoints(2);
    }


}
