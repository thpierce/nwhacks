using UnityEngine;
using System.Collections;

public class TrashDragScript : MonoBehaviour {

	Vector3 screenSpace;
	Vector3 offset;
	void OnMouseDown()
	{	
		//translate the cubes position from the world to Screen Point
		screenSpace = Camera.main.WorldToScreenPoint(transform.position);
		//calculate any difference between the cubes world position and the mouses Screen position converted to a world point  
		offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y, screenSpace.z));

		// Stop the trash from moving to the right
	}
	
	void OnMouseDrag()
	{
		Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenSpace.z); 
		Vector3 curPosition =  Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;
		transform.position = curPosition;
	}
}
