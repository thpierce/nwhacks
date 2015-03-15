using UnityEngine;
using System.Collections;

public class StartGameScript : MonoBehaviour {

	public Texture startGame;

	public float guiPlacementX1;
	public float guiPlacementX2;

	public float guiPlacementY1;
	public float guiPlacementY2;


	void OnGUI () {
	
		if (GUI.Button (new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * guiPlacementX2, Screen.height * guiPlacementY2), startGame, "")){
		    Application.LoadLevel("stage1");
		}
	}
}
