using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class Hit1Brick : MonoBehaviour {

    int TimesHit;
    public int MaxHit;
    LevelManager LevelManager = new LevelManager();
    public static int breakableCount = 0;
    AudioClip crack;
   

	// Use this for initialization
	void Start () {
        crack = Resources.Load("Sounds/crack", typeof(AudioClip)) as AudioClip;
        TimesHit = 0;
        breakableCount++;
        
       
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        TimesHit++;
        //print(gameObject.name + ": " + TimesHit);

        AudioSource.PlayClipAtPoint(crack, this.transform.position);

        if (TimesHit >= MaxHit)
        {
            //TestWin();
            breakableCount--;
            if (breakableCount <= 0)
            {
                Win();
            }
            Destroy(gameObject);
        }
    }

    void Win()
    {
        LevelManager.LoadNextScene();
    }
}
