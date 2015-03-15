using UnityEngine;

/// <summary>
/// Projectile behavior
/// </summary>
public class TrashCanScript : MonoBehaviour
{
	public string bintype = "";

	void OnTriggerEnter2D(Collider2D otherCollider)
	{
		GameObject gameobject = otherCollider.gameObject;
		WasteTypeScript wastetypescript = gameobject.GetComponent<WasteTypeScript> ();

		// Remove the other collider if it's waste of the right type
		if (wastetypescript != null && bintype.Equals (wastetypescript.type)) {
			// Increase score
			// Destroy
			Destroy (gameobject);
		} else {
			// Decrease score
		}
	}		
}
