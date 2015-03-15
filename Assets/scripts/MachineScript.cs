using UnityEngine;
using System.Collections;

public class MachineScript : MonoBehaviour {
	public Transform garbagePrefab;
	public double startTime;
	public double nextTime;
	public Vector3 randomPosition;

	
	void Start()
	{
		startTime = Time.time;
		nextTime = Time.time;
	}
	
	void Update()
	{
		if (Time.time > nextTime){
			double minutes = (Time.time - startTime)/5.0;
			nextTime = Time.time + 5.001 / (minutes + 1.0);
			MakeNewGarbage ();
		}
	}
	
	public void MakeNewGarbage()
	{
		int randomY = Random.Range (-3, 3);
		randomPosition = new Vector3 (transform.position.x,randomY,5);
		var garbageTransform = Instantiate(garbagePrefab) as Transform;
		garbageTransform.position = randomPosition;
	}

}
