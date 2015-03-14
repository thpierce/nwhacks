using UnityEngine;

/// <summary>
/// Simply moves the current game object
/// </summary>
public class TrashMoveScript : MonoBehaviour
{
	// Amount to move down the conveyor belt on each frame
	public Vector2 movement = new Vector2(3, 0);

	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
