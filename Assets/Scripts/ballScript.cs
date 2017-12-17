using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballScript : MonoBehaviour {
    public float ballVelocity = 1000;
    Rigidbody rb;//Adding a Rigidbody component to an object will put its motion under the control of Unity's physics engine. Even without adding any code.
    bool isPlay;//This will be true when the ball is moving;
    int randInt;//When click, the ball goes to a random deriction

    //Awake is used to initialize any variables or game state before the game starts. 
    void Awake()
    {
        //Initializing the variables
        rb = gameObject.GetComponent<Rigidbody>();//Getting the rigidbody component
        randInt = Random.Range(1, 3);
    }
    void Update ()
    {
        if(Input.GetMouseButton(0)==true && isPlay==false){//0 is a left click
            transform.parent = null;
            isPlay = true;
            rb.isKinematic = false;//Switch off kinematic in Unity from VS
            if (randInt==1)
            {
                rb.AddForce(new Vector3(ballVelocity, ballVelocity, 0));
            }
            if (randInt==2)
            {
                rb.AddForce(new Vector3(-ballVelocity, -ballVelocity, 0));
            }
        }
	}
}
