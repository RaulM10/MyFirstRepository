using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScript : MonoBehaviour {

    public void LoadStartScene()
    {
        SceneManager.LoadScene("Start");
    }

    public void QuitScene()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
}
