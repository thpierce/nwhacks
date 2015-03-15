using UnityEngine;
using System.Collections;

public class ScoreRememberScript : MonoBehaviour {

	public int score = 0;
	void Start () {
		DontDestroyOnLoad(gameObject);
	}
}
