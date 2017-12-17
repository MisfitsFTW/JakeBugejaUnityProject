using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opponentPaddle : MonoBehaviour {
    //the paddle speed is controlled with this variable
    ////public float opponentPaddleSpeed = 1;
    //Vector passes 3D positions
    ////public Vector3 opponentPlayerPos;
    // Use this for initialization
    public Vector3 newPaddlePos;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = (Input.mousePosition.y / Screen.width * 18) - 8;

        //newPaddlePos = new Vector3( gameObject.transform.position.x, gameObject.transform.position.y, mousePosInUnits);//Transform is on the Inspector, it stores the positions

        newPaddlePos = new Vector3(7, Mathf.Clamp(mousePosInUnits, -3.4F, 3.4F), 0);
        newPaddlePos.y = Mathf.Clamp(mousePosInUnits, -3.35f, 3.5f);

        gameObject.transform.position = newPaddlePos;
        
    }
}
