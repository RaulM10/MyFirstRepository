using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour {

    public Text WelText;

    enum States { cell, sheets_0, mirror, lock_0, cell_mirror, sheets_1, lock_1, corridor_0, stairs_0, stairs_1, stairs_2, floor, closet_door, in_closet, corridor_1, corridor_2, corridor_3, courtyard}
    States MyState;

	// Use this for initialization
	void Start () {
        MyState = States.cell;

	}
	
	// Update is called once per frame
	void Update () {

        if (MyState == States.cell) { Cell(); }
        else if (MyState == States.sheets_0) { Sheets_0(); }
        else if (MyState == States.mirror) { Mirror(); }
        else if (MyState == States.lock_0) { Lock_0(); }
        else if (MyState == States.cell_mirror) { Cell_Mirror(); }
        else if (MyState == States.sheets_1) { Sheets_1(); }
        else if (MyState == States.lock_1) { Lock_1(); }
        else if (MyState == States.corridor_0) { Corridor_0(); }
        else if (MyState == States.stairs_0) { Stairs_0(); }
        else if (MyState == States.stairs_1) { Stairs_1(); }
        else if (MyState == States.stairs_2) { Stairs_2(); }
        else if (MyState == States.floor) { Floor(); }
        else if (MyState == States.closet_door) { Closet_Door(); }
        else if (MyState == States.corridor_1) { Corridor_1(); }
        else if (MyState == States.corridor_2) { Corridor_2(); }
        else if (MyState == States.corridor_3) { Corridor_3(); }
        else if (MyState == States.in_closet) { In_Closet(); }
        else if (MyState == States.courtyard) { Courtyard(); }
    }

    void Cell()
    {
        WelText.text = "You are in a Prison Cell, and you want to escape. \nThere are some dirty sheets on the bed, A Mirror Cell and a Lock\n\n" +
                       "Press S to view the Sheets, M to view to Mirror and L to view the Lock";

        if (Input.GetKeyDown(KeyCode.S)) { MyState = States.sheets_0; }
        else if (Input.GetKeyDown(KeyCode.M)) { MyState = States.mirror; }
        else if (Input.GetKeyDown(KeyCode.L)) { MyState = States.lock_0; }
    }

    void Sheets_0()
    {
        WelText.text = "These sheets are very Dirty! They really need to be changed \n\n"
            + "Press R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { MyState = States.cell; }
    }

    void Lock_0()
    {
        WelText.text = "This is one of those button locks. You have no idea what the combination is. " 
                        + "You wish you could somehow see where dirty fingerprints were on the buttons." 
                        + "\n\n Press R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { MyState = States.cell; }
    }

    void Mirror()
    {
        WelText.text = "The dirty old mirror on the wall seems loose. \n\n"
                       + "Press T to take the mirror, R to return back to the cell";
        
        if (Input.GetKeyDown(KeyCode.T)) { MyState = States.cell_mirror; }
        else if (Input.GetKeyDown(KeyCode.R)) { MyState = States.cell; }
    }

    void Cell_Mirror()
    {
        WelText.text = "You are still in your cell and you STILL want to escape! There are some dirty sheets "
                        + "on the bed, a mark where the mirror was and the door which is still firm locked. \n\n"
                        + "Press S to view the Sheets, L to view the Lock";

        if (Input.GetKeyDown(KeyCode.S)) { MyState = States.sheets_1; }
        else if (Input.GetKeyDown(KeyCode.L)) { MyState = States.lock_1; }
    }

    void Sheets_1()
    {
        WelText.text = "Holding a Mirror in your Hand, won't make the sheets look any better! \n\n"
                        + "Press R to return back to the middle of the cell.";

        if (Input.GetKeyDown(KeyCode.R)) { MyState = States.cell_mirror; }
    }

    void Lock_1()
    {
        WelText.text = "You carefully put the mirror throught the bars, and turn it round so you can see the "
                        + "lock. You can see where the fingerprints are on the dirty buttons. You press on the dirty buttons "
                        + "and hear a click. \n\n"
                        + "Press O to open the cell door, R to return to the cell";

        if (Input.GetKeyDown(KeyCode.O)) { MyState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.R)) { MyState = States.cell_mirror; }
    }

    void Corridor_0()
    {
        WelText.text = "You have gone out of the the cell and find yourself to a pile of stairs, a dirty floor and a closet door \n\n"
                       + "Press S to Climb the Stairs, F to rummage through the dirty floor, and C to check inside the Closet Door";

        if (Input.GetKeyDown(KeyCode.S)) { MyState = States.stairs_0; }
        else if (Input.GetKeyDown(KeyCode.F)) { MyState = States.floor; }
        else if (Input.GetKeyDown(KeyCode.C)) { MyState = States.closet_door; }
    }

    void Stairs_0()
    {
        WelText.text = "You start walking up the stairs towards the outside light. " +
                        "You realise it's not break time, and you'll be caught immediately. " +
                        "You slither back down the stairs and reconsider.\n\n" +
                        "Press S to Climb back down the Stairs ";


        if (Input.GetKeyDown(KeyCode.S)) { MyState = States.corridor_0; }
    }

    void Floor()
    {
        WelText.text = "Rummaging around on the dirty floor, you find a hairclip.\n\n" +
                        "Press C to go to Corridor 1, R to return to near your opened cell";

        if (Input.GetKeyDown(KeyCode.C)) { MyState = States.corridor_1; }
        else if (Input.GetKeyDown(KeyCode.R)) { MyState = States.corridor_0; }
    }

    void Closet_Door()
    {
        WelText.text = "You are looking at a closet door, unfortunately it's locked. " +
                        "Maybe you could find something around to help enourage it open? *A Hairclip is not very useful*\n\n" +
                        "Press R to return to near your opened cell";

        if (Input.GetKeyDown(KeyCode.R)) { MyState = States.corridor_0; }
    }

    void Corridor_1()
    {
        WelText.text = "Still in the corridor. Floor still dirty. Hairclip in hand. " +
                        "Now what? You wonder if that lock on the closet would succumb to " +
                        "to some lock-picking?\n\n" +
                        "Press S to climb the stairs, C to try to pick the closet";

        if (Input.GetKeyDown(KeyCode.C)) { MyState = States.in_closet; }
        else if (Input.GetKeyDown(KeyCode.S)) { MyState = States.stairs_1; }
    }

    void Stairs_1()
    {
        WelText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
                        "confidence to walk out into a courtyard surrounded by armed guards!\n\n"
                        + "Press R to return to the corridor";

        if (Input.GetKeyDown(KeyCode.R)) { MyState = States.corridor_1; }
    }

    void In_Closet()
    {
        WelText.text = "Inside the closet you see a cleaner's uniform that looks about your size! " +
                       "Seems like your day is looking-up.\n\n" +
                       "Press C to go to corridor without the uniform, Press D to go to another corridor with the uniform";

        if (Input.GetKeyDown(KeyCode.C)) { MyState = States.corridor_2; }
        else if (Input.GetKeyDown(KeyCode.D)) { MyState = States.corridor_3; }
    }

    void Corridor_2()
    {
        WelText.text = "Still in the corridor\n\n" +
                       "Press S to climb the stairs, Press R to return to the closet";

        if (Input.GetKeyDown(KeyCode.S)) { MyState = States.stairs_2; }
        else if (Input.GetKeyDown(KeyCode.R)) { MyState = States.in_closet; }
    }

    void Stairs_2()
    {
        WelText.text = "Unfortunately wielding a puny hairclip hasn't given you the " +
                        "confidence to walk out into a courtyard surrounded by armed guards!\n\n"
                        + "Press R to return to the corridor";

        if (Input.GetKeyDown(KeyCode.R)) { MyState = States.corridor_2; }
    }

    void Corridor_3()
    {
            WelText.text = "You're standing back in the corridor, now convincingly dressed as a cleaner."   
                           +"You strongly consider the run for freedom.\n\n"
                           + "Press R to Undress and return back to the Closet, Press C to go to the Courtyard";

            if (Input.GetKeyDown(KeyCode.R)) { MyState = States.corridor_2; }
            else if (Input.GetKeyDown(KeyCode.C)) { MyState = States.courtyard; }
    }

    void Courtyard()
    {
        WelText.text = "You walk through the courtyard dressed as a cleaner. " +
                       "The guard tips his hat at you as you waltz past, claiming " +
                       "your freedom. You heart races as you walk into the sunset.\n\n" +
                       "Press P to Play Again, Press Q to Quit";


        if (Input.GetKeyDown(KeyCode.P)) { MyState = States.corridor_0; }
        else if (Input.GetKeyDown(KeyCode.Q)) { UnityEditor.EditorApplication.isPlaying = false; ; }
    }
}
