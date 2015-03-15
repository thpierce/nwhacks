using UnityEngine;
using System.Collections;

public class MachineScript : MonoBehaviour {
	public Transform garbagePrefab;
	public double startTime;
	public double nextTime;
	public Vector3 randomPosition;
	public int level = 0;
	private int countGarbage = 0;
	private float[] averageGarbageTimes = new float[] {3.5f, 2.5f, 1.5f, 1f, 0.5f};
	
	void Start()
	{
		startTime = Time.time;
		nextTime = Time.time+5;
	}
	
	void Update()
	{
		float nextTimeInterval;
		if ((Time.time) > nextTime) {
			MakeNewGarbage ();
			countGarbage++;
			nextTimeInterval= Random.Range(averageGarbageTimes[level] - 0.5f, averageGarbageTimes[level] + 0.5f);
			nextTime = Time.time + nextTimeInterval;
			print ("next time: " + nextTime);
		}
		if (countGarbage > 10*level){
			countGarbage = 0;
			level++;
			print ("multiplyer: " + level);
		}

		if (level == 5){
			Application.LoadLevel("gameoverwin");
		}
	}

	public int GetLevel(){
		return level;
	}
	
	public void MakeNewGarbage()
	{
		int randomY = Random.Range (-3, 3);
		randomPosition = new Vector3 (transform.position.x,randomY,5);
		var garbageTransform = Instantiate(garbagePrefab) as Transform;
		garbageTransform.position = randomPosition;

	}

}
