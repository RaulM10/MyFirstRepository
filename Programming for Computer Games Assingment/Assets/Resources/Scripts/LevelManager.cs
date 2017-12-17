using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadNewSceneIndex()
    {
        int CurrentScene = SceneManager.GetActiveScene().buildIndex;
        CurrentScene++;
        SceneManager.LoadScene(CurrentScene);
    }

    public void LoadNewScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void QuitGame()
    {
        UnityEditor.EditorApplication.isPlaying = false;
    }
  
}
