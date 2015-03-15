using UnityEngine;
using System.Collections;

public class BinScript : MonoBehaviour{
	public string binType;

	void OnTriggerEnter2D(Collider2D otherCollider){
		WasteTypeScript wastetypescript = otherCollider.gameObject.GetComponent<WasteTypeScript> ();

		// Remove the other collider if it's waste of the right type
		if (wastetypescript != null && binType.Equals (wastetypescript.type)) {
			int mult = transform.Find("/Level/2 - Foreground/Machine").GetComponent<MachineScript>().GetLevel();
			transform.Find("/Render/ScoreKeeper").GetComponent<ScoreScript>().UpdateScore(20 * mult);
			Destroy (otherCollider.gameObject);
		} else {
			transform.Find("/Render/ScoreKeeper").GetComponent<ScoreScript>().UpdateScore(-10);
		}
	}		
}
