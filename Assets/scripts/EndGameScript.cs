using UnityEngine;
using System.Collections;

public class EndGameScript : MonoBehaviour {
	
	public Texture mainMenu;

	public Texture playAgain;
	
	public float guiPlacementX1;
	public float guiPlacementX2;
	
	public float guiPlacementY1;
	public float guiPlacementY2;
	
	
	void OnGUI () {

		//play again
		if (GUI.Button (new Rect(Screen.width * guiPlacementX2, Screen.height * guiPlacementY2, Screen.width * .7f, Screen.height * .2f), playAgain, "")){
			Application.LoadLevel("stage1");
			print ("clicked pa");
		}
		//go to main menu
		if (GUI.Button (new Rect(Screen.width * guiPlacementX1, Screen.height * guiPlacementY1, Screen.width * .7f, Screen.height * .2f), mainMenu, "")){
			Application.LoadLevel("menu");
			print ("clicked mm");
		}

	}
}
