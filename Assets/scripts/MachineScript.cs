using UnityEngine;
using System.Collections;

public class MachineScript : MonoBehaviour {
	//--------------------------------
	// 1 - Designer variables
	//--------------------------------
	
	/// <summary>
	/// Projectile prefab for shooting
	/// </summary>

	public Transform garbagePrefab;
	/// <summary>
	/// Cooldown in seconds between two shots
	/// </summary>
	public double startTime;
	public double nextTime;
	public Vector3 randomPosition;
	//--------------------------------
	// 2 - Cooldown
	//--------------------------------

	
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
			MakeNewGarbage (true);
		}
	}
	
	//--------------------------------
	// 3 - Shooting from another script
	//--------------------------------
	
	/// <summary>
	/// Create a new projectile if possible
	/// </summary>
	public void MakeNewGarbage(bool isEnemy)
	{
			int randomY = Random.Range (-3, 3);
			randomPosition = new Vector3 (-7,randomY,5);
			var garbageTransform = Instantiate(garbagePrefab) as Transform;
			garbageTransform.position = randomPosition;
			//TrashMoveScript move = garbageTransform.gameObject.GetComponent<TrashMoveScript>();
//			if (move != null)
//			{
//				move.direction = this.transform.right; // towards in 2D space is the right of the sprite
//			}
	}

}
