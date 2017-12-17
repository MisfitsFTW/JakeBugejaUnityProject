using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerGoalScript : MonoBehaviour {
    public UIManagerScript uiObj;
	// Use this for initialization
	void Start () {
        //This line is used fotr the use of methods from UIManagerScript
        uiObj = GameObject.FindObjectOfType(typeof(UIManagerScript)) as UIManagerScript;
        //uiObj.getPlayerScore();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "puck")
        {
            uiObj.getPlayerScore();
        }
    }
}
