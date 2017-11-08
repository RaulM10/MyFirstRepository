using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainSceneScript : MonoBehaviour {

    int num1;
    int num2;
    public InputField ResultField;
    public Button AnswerButton;
    public Text QuestionText;
    public Text FinalComment;
    System.Random Rand = new System.Random();

    // Use this for initialization
    void Start()
    {
        
        num1 = Rand.Next(1, 11);
        num2 = Rand.Next(1, 11);
        QuestionText.text = "What is " + num1 + " x " + num2 + " ?";

    }

    // Update is called once per frame
    void Update() {

    }

    public void CheckAnswer()
    {
        int UserAnswer = System.Convert.ToInt32(ResultField.text);
        int MultAns = num1 * num2;

        if (MultAns == UserAnswer)
        {
            print("Correct");
        }
        else
        {
            print("Incorrect");
        }


    }

    void GenerateAnswer()
    {




    }
   



}
