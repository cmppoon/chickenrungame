using UnityEngine;
using System.Collections;

public class Coin : MonoBehaviour {
	public int gaugeValue = 1;

	private GameControl gc;

	// Use this for initialization
	void Start () {
		gc = FindObjectOfType<GameControl> ();
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter2D(Collision2D other){
		if(other.gameObject.tag == "Player"){
			gc.AddGauge (gaugeValue);
			Destroy (gameObject);
		}
		if(other.gameObject.tag == "Killplane"){
			Destroy (gameObject);
		}
	}
}
