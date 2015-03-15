using UnityEngine;
using System.Collections;

public class BeltScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	}
	
	private Vector3 movement = Vector3.left * 0.1f;
	private Vector3 resetSpot = new Vector3 (-1,0,5);

	public void Update() {
		if (transform.position.x < 1) {
			movement = Vector3.right * 0.1f;
			transform.Translate(movement);
		}else
			transform.position = resetSpot;
	}
}
