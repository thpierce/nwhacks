using UnityEngine;
using System.Collections;

public class TrashDragScript : MonoBehaviour {

	Vector3 screenSpace;
	Vector3 offset;

	void OnMouseDown()
	{	
		gameObject.GetComponent<BoxCollider2D>().enabled = false;
		//translate the cubes position from the world to Screen Point
		screenSpace = Camera.main.WorldToScreenPoint(transform.position);
		//calculate any difference between the cubes world position and the mouses Screen position converted to a world point  
		offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, screenSpace.z));

		// Stop the trash from moving to the right
		TrashMoveScript movescript = GetComponent<TrashMoveScript> ();
		movescript.enabled = false;
		rigidbody2D.velocity = new Vector2(0, 0);

	}

	void OnMouseUp()
	{
		gameObject.GetComponent<BoxCollider2D>().enabled = true;
		// Put the trash back on the conveyor belt
		rigidbody2D.gravityScale = 1.0f;

	}

	void OnMouseDrag()
	{
		rigidbody2D.velocity = new Vector2(0, 0);
		Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z); 
		Vector3 curPosition =  Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
		transform.position = curPosition;
	}

	void FixedUpdate()
	{
		if (rigidbody2D.gravityScale > 0 && transform.position.y <= 0) {
			rigidbody2D.gravityScale = 0;
			TrashMoveScript movescript = GetComponent<TrashMoveScript> ();
			movescript.enabled = true;
		}
	}
}
