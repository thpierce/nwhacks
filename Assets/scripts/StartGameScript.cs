using UnityEngine;
using System.Collections;

public class StartGameScript : MonoBehaviour {

	void OnGUI () {
		const int width = 100;
		const int height = 50;

		Rect start = new Rect(
			Screen.width/2 - width/2,
			3*Screen.height/4 - height/2,
			width,
			height);

		if (GUI.Button (start, "Start Game")){
			Application.LoadLevel("stage1");
		}
	}
}
