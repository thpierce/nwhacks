using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

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
		print("Score: "+score);
		GetComponent<GUIText>().text = "Score: " + score.ToString();
	}
}
