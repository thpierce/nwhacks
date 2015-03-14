using UnityEngine;
using System.Collections;

public class WasteCollisionScript : MonoBehaviour {

	void OnCollisionEnter2D(Collision2D coll){
		if (coll.gameObject.tag == "WasteItem"){
			Physics2D.IgnoreCollision(coll.gameObject.GetComponent<Collider2D>(), GetComponent<Collider2D>());
		}
	}
}
