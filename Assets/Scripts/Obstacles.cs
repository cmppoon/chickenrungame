using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	private GameControl gc;
	private PlayerController thePlayer;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType<GameControl>();
		thePlayer = FindObjectOfType<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			gc.ResetScrollSpeed();
			Destroy (gameObject);
		}
		if(other.tag == "Killplane"){
			Destroy (gameObject);
		}
	}
}
