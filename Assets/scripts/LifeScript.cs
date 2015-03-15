using UnityEngine;
using System.Collections;

public class LifeScript : MonoBehaviour {
	private int livesRemaining = 3;


	public void loseLife(){
		livesRemaining -= 1;
		if (livesRemaining == 0) {
			Application.LoadLevel ("gameover");
		} else {
			print(livesRemaining.ToString ());
			// Get the image with the right number of hearts
			Sprite[] sprites = Resources.LoadAll<Sprite>("3hearts_0");
			gameObject.GetComponent<SpriteRenderer>().sprite = sprites[livesRemaining - 1];
		}
	}
}
