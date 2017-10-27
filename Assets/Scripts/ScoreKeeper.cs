using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour {

    public int health = 100;
    public int score = 0;
    public Text healthText;
    public Text scoreText;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void scoreUp(int points)
    {
        score += points;
        scoreText.text = score.ToString();
    }

    public void healthDown(int num)
    {
        health -= num;
        healthText.text = health.ToString();
    }
}
