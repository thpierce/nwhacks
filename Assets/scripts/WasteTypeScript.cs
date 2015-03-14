using UnityEngine;
using System.Collections;

public class WasteTypeScript : MonoBehaviour {

	public string type;
	private string[] types = new string[3] {"compost", "container", "paper"};

	// Use this for initialization
	void Start () {

		int randType = Random.Range (0, 3);
		string[] images = null;

		type = types[randType];
		switch (randType){
			case 0:
			images =  new string[3] {"banana", "apple", "fish"};
			break;
			case 1:
			images =  new string[4] {"bottle", "milk", "tuna_can", "can"};
			break;
			case 2:
			images =  new string[3] {"newspaper", "box", "pizza_box"};
			break;
		}

		string randImage = images[Random.Range(0, images.Length)];
		gameObject.GetComponent<SpriteRenderer>().sprite = Resources.Load(randImage, typeof(Sprite)) as Sprite;
	}
}