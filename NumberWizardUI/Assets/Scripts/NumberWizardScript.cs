using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NumberWizardScript : MonoBehaviour
{

    public Text GuessText;
    public Text LivesText;
    int min = 0;
    int max = 0;
    int lives = 5;
    System.Random Rand = new System.Random();
    int guess = 0;

    // Use this for initialization
    void Start()
    {
        
        StartGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void NextGuess()
    {
        if (lives == 0)
        {
            SceneManager.LoadScene("Lose");
        }
        else
        {
            guess = (min + max) / 2;
            GuessText.text = guess + "?";
            LivesText.text = "You have " + lives + " lives left.";
        }

    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = Rand.Next(min, max);

        NextGuess();
    }

    public void GuessHigher()
    {
        min = guess + 1;
        lives--;
        NextGuess();
    }

    public void GuessLower()
    {
        max = guess - 1;
        lives--;
        NextGuess();
    }

    public void LoadNewScene()
    {
        SceneManager.LoadScene("Win");
    }

 



}
