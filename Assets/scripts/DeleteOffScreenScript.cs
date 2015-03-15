using UnityEngine;
using System.Collections;

public class DeleteOffScreenScript : MonoBehaviour {

	void Update(){
		Vector2 thisPos = Camera.main.WorldToScreenPoint(transform.position);
		if (thisPos.x > Screen.width){
			Destroy(gameObject);
			transform.Find("/Level/2 - Foreground/Life Counter").GetComponent<LifeScript>().loseLife();
		}
	}
}
