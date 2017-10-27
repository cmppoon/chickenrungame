using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {
	public float enemySpeedAcceleration;
	public float enemySpeed;

	private GameControl gc;
	private float speedRelativeToHuman;
	private Rigidbody2D rb;
	private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType<GameControl>();
		speedRelativeToHuman = enemySpeed + gc.GetStartScrollSpeed();
		rb = GetComponent<Rigidbody2D>();
		rb.velocity = new Vector3 (speedRelativeToHuman, 0, 0);
		thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		speedRelativeToHuman = enemySpeed + gc.GetScrollSpeed();
		rb.velocity = new Vector3 (speedRelativeToHuman, 0, 0);
		enemySpeed += enemySpeedAcceleration * (Time.deltaTime/50) ;
//		Debug.Log(rb.velocity);
	}

	void OnCollisionEnter2D (Collision2D other)
	{
		if (other.gameObject.tag == "Player") {
			thePlayer.isDead = true;
			Debug.Log("Dead");
		}
	}
}
