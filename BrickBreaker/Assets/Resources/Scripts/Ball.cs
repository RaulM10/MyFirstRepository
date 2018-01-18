using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    Paddle paddle;
    Vector3 PaddleBallPosDiff;
    bool GameStarted = false;

    AudioClip boing;
    // Use this for initialization
    void Start () {
        boing = Resources.Load("Sounds/boing", typeof(AudioClip)) as AudioClip;
        paddle = GameObject.FindObjectOfType<Paddle>();
        PaddleBallPosDiff = this.transform.position - paddle.transform.position;

    }
	
	// Update is called once per frame
	void Update () {

        if (!GameStarted)
        {
            this.transform.position = paddle.transform.position + PaddleBallPosDiff;
        }

        if(Input.GetMouseButtonDown(0) && !GameStarted)
        {
            GameStarted = true;
            this.GetComponent<Rigidbody2D>().velocity = new Vector2(2f, 10f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string colName = collision.collider.name;
        string colTag = collision.collider.tag;
        //if (GameStarted && (colName == "Paddle" || colName == "LeftBorder" || colName == "RightBorder" || colName == "TopBorder"))
        if(GameStarted && (colTag != "Breakable"))
        {
            GetComponent<AudioSource>().PlayOneShot(boing);
        }

        this.GetComponent<Rigidbody2D>().velocity = new Vector2(Random.Range(-0.2f, 0.2f), 0f);
    }
}
