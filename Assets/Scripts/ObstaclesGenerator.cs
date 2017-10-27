using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesGenerator : MonoBehaviour {

	public GameObject obstacle; 
	
	private PlayerController thePlayer;
	private float generatorThreshold = 50f;
	private float nextSpawnTime = 5f;
	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time >= nextSpawnTime) {
			if (Random.Range (0, 100) < generatorThreshold) {
				SpawnObstacles();
			}
			nextSpawnTime += 5f;
		}
	}

	public void SpawnObstacles ()
	{
		GameObject newObstacle = Instantiate(obstacle, thePlayer.transform.position + new Vector3 (5f, 1f, 0f),thePlayer.transform.rotation) as GameObject;
		newObstacle.transform.parent = gameObject.transform;
	}
}
