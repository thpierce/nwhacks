using UnityEngine;
using System.Collections;

public class BinScript : MonoBehaviour{
	public string binType;

	void OnTriggerEnter2D(Collider2D otherCollider){
		WasteTypeScript wastetypescript = otherCollider.gameObject.GetComponent<WasteTypeScript> ();

		// Remove the other collider if it's waste of the right type
		if (wastetypescript != null && binType.Equals (wastetypescript.type)) {
			// Increase score
			// Destroy
			Destroy (otherCollider.gameObject);
		} else {
			// Decrease score
		}
	}		
}
