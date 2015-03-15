using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreScript : MonoBehaviour {

	private int score;
	private string scoreText;
	public Font ScoreFont;

	void Start () {
		score = 0;
		scoreText = "SCORE: 0";
	}
	
	public void UpdateScore (int change) {
		score = Mathf.Max(0, score + change);
		transform.Find("/Scripts/ScoreRemember").GetComponent<ScoreRememberScript>().score += score;
		scoreText = "SCORE: " + score.ToString();
	}

	void OnGUI () {
		GUI.skin.font = ScoreFont;
		string message = "<color=black><size=30>"+scoreText+"</size></color>";
		GUI.Label(new Rect (10, 10, 400, 60), message);	
	}
}
