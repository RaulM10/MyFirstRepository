using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddingNumbersScript : MonoBehaviour {

    int UserNum = 50;


    // Use this for initialization
    void Start () {
        print("Press Up Arrow to Increment 1 from 50.");
        print("Press Down Arrow to Decrement 1 from 50");
        print("Press Enter Button to Stop the Program from Executing");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("up"))
        {
            print("Up Arrow was Pressed and the Number was Incremented by 1");
            UserNum++;
            print("The number is now " + UserNum);
        }


        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down Arrow was Pressed and the Number was Decremented by 1");
            UserNum = UserNum - 1;
            print("The number is now " + UserNum);
            
        }

        else if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
           UnityEditor.EditorApplication.isPlaying = false;
        }
    }
}
