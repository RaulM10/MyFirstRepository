using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit1Brick : MonoBehaviour {

    int TimesHit;
    public int MaxHit;
    LevelManager LevelManager = new LevelManager();

	// Use this for initialization
	void Start () {
        TimesHit = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TimesHit++;
        print(gameObject.name + ": " + TimesHit);

        if (TimesHit >= MaxHit)
        {
            //TestWin();
            Destroy(gameObject);
        }
    }

   /* void TestWin()
    {
        LevelManager.LoadNextScene();
    }*/
}
