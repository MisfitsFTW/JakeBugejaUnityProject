using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManagerScript : MonoBehaviour {
    public Text scoreText;
    int playerScore;
    int opponentScore;
	// Use this for initialization
	void Start () {
        playerScore=0;
        opponentScore=0;

    }
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "" + playerScore + " : " + opponentScore;

    }
    public void getPlayerScore()
    {
        playerScore++;
    }
    public void getOpponentScore()
    {
        opponentScore++;
    }
}
