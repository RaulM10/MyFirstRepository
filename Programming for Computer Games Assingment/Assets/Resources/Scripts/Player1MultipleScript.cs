﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player1MultipleScript : MonoBehaviour {

    private Player1Scores player1Score;

    // Use this for initialization
    void Start()
    {
        player1Score = GetComponent<Player1Scores>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        player1Score.AddPoints(1);
    }
}
