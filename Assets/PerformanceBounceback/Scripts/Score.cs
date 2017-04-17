using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public GameManager gameManager;
	private int currentScore;
	private Text text;

	// Use this for initialization
	void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
		text = GetComponentInChildren<Text>();
		updateScore (gameManager.score);
	}
	
	// Update is called once per frame
	void Update () {
		if (currentScore != gameManager.score) {
			updateScore (gameManager.score);
		}
	}

	private void updateScore(int newScore) {
		currentScore = newScore;
		text.text = "Score: " + newScore;
	}
}
