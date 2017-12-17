using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour {
    //the paddle speed is controlled with this variable
    public float paddleSpeed=1;
    //Vector passes 3D positions
    public Vector3 playerPos;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //gameObject
        //gamObject applies to the specific dragged object

        //transform
        //Every object in a scene has a Transform. It's used to store and manipulate the position, rotation and scale of the object. 
        //Every Transform can have a parent, which allows you to apply position, rotation and scale hierarchically.

        //position
        //Changing it's Y position

        //+ (Input.GetAxis("Vertical"));
        //Input.GetAxis("Vertical") will not return true once you stop pressing the up key. 
        //Or rather it will but only for another frame or so. 
        //What Input.GetAxis does is whenever you press the key or joystick associated with that axis it returns a number 
        //between -1 and 1. - 1 would be down in this case, 0 would be neutral, and 1 would be up.With GetAxis there is a smoothing 
        //calculation applied, so if you press Up or W it will start going towards 1 but it might not get there the first frame, 
        //you may get a decimal such as 0.33.And once you let go it will smooth back down to 0 so you will still get a small amount of movement. 
        //That's why he said you should use GetAxisRaw, because it just checks if the key is being pushed at that frame, it can ONLY return -1, 0, or 1 never a decimal point. 
        //So as soon as you let go you get 0.
        float yPos = gameObject.transform.position.y + (Input.GetAxis("Vertical")*paddleSpeed);
        playerPos = new Vector3(-7, Mathf.Clamp(yPos,-3.4F, 3.4F),0);//F, tells VS it is a float
        gameObject.transform.position = playerPos;
	}
}
