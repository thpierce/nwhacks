using UnityEngine;
using System.Collections;

public class LifeScript : MonoBehaviour {
	private int livesRemaining = 3;

	public void loseLife(){
		Destroy (transform.Find("/Level/2 - Foreground/life" + livesRemaining.ToString()).gameObject);
		livesRemaining -= 1;
		if (livesRemaining == 0){
			Application.LoadLevel("gameover");
		}
	}
}
