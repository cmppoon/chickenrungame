using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGenerator : MonoBehaviour {

	public GameObject objectToGenerate;
	public float generateThreshold;
	public float nextSpawnTime;

	private PlayerController thePlayer;
	private float startSpawnTime;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController>();
		startSpawnTime = nextSpawnTime;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Time.time > nextSpawnTime) {
			if (Random.Range (0, 100) < generateThreshold) {
				GenerateObject();
			}
			nextSpawnTime += startSpawnTime;
		}
	}

	private void GenerateObject() {
		GameObject newGameObject = Instantiate(objectToGenerate, thePlayer.transform.position + new Vector3 (5f, 1f, 0f),thePlayer.transform.rotation) as GameObject;
		newGameObject.transform.parent = gameObject.transform;
	}
}
