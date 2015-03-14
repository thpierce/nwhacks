using UnityEngine;

/// <summary>
/// Projectile behavior
/// </summary>
public class TrashCanScript : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D otherCollider)
	{

		// Destroy the shot
		Destroy (otherCollider.gameObject); // Remember to always target the game object, otherwise you will just remove the script
	}		
		
	
}
