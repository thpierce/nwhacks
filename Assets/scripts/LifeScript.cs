using UnityEngine;
using System.Collections;

public class LifeScript : MonoBehaviour {
	public GameObject life1;
	public GameObject life2;
	public GameObject life3;
	private GameObject[] lives = new GameObject[3];
	private int livesRemaining = 3;

	void Start(){
		lives[0] = life1;
		lives[1] = life2;
		lives[2] = life3;
	}

	public void loseLife(){
		livesRemaining -= 1;
		GameObject toDelete = lives[livesRemaining];
		Destroy (toDelete);
		if (livesRemaining == 0){
			Application.LoadLevel("gameover");
		}
	}
}
