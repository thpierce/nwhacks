using UnityEngine;
using System.Collections;

public class DeleteOffScreenScript : MonoBehaviour {
	// scrolling indicated is the object is visible 
	// and scrolling across the screen
	private bool scrolling = false;

	public GameObject scripts;

	// When we start rendering, it is scrolling
	// across the screen.
	void OnBecameVisible() {
		scrolling = true;
	}

	// If it was scrolling and became invisible,
	// it has fallen off the screen and should be
	// destroyed.
	void OnBecameInvisible(){
		if (scrolling){
			Destroy(gameObject);
		}
		scripts.GetComponent<LifeScript>().loseLife();
	}
}
