using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private int score;

	void Start () {
		score = 0;
		drawScore();
	}
	
	public void UpdateScore (int change) {
		score += change;
		drawScore();
	}

	void drawScore() {
		GetComponent<GUIText>().text = "Score: " + score.ToString();
	}
}
