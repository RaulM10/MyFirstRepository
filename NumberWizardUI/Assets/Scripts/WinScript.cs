using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {

    

    public void LoadNewScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitScene()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }



}
