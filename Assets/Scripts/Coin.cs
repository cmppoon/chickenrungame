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

	void OnTriggerEnter2D(Collider2D other){
		if(other.tag == "Player"){
			gc.AddGauge (gaugeValue);
			Destroy (gameObject);
		}
		if(other.tag == "Killplane"){
			Destroy (gameObject);
		}
	}
}
