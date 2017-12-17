using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleScript : MonoBehaviour {

    float speed = 1000f;


    // Use this for initialization
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        transform.Rotate(0, speed * Time.deltaTime, 0);


    }




}
