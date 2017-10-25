using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {
	

	private Rigidbody2D rb2d;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
		if (sr.sortingOrder == 1 ){
			rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed*0.2f,0f);
		}
		else if (sr.sortingOrder == 2 ){
			rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed*0.4f,0f);
		}
		else if (sr.sortingOrder == 3 ){
			rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed*0.6f,0f);
		}
		else if (sr.sortingOrder == 4 ){
			rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed*0.8f,0f);
		}
		else if (sr.sortingOrder == 5 ){
			rb2d.velocity = new Vector2 (GameControl.instance.scrollSpeed*1f,0f);
		}
	}

	// Update is called once per frame
	void Update () {
		if (GameControl.instance.gameOver == true) {
			rb2d.velocity = Vector2.zero;
		}
	}
}
