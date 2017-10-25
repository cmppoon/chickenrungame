﻿using UnityEngine;
using System.Collections;

public class RepeatingBackground : MonoBehaviour {

	private BoxCollider2D groundCollider;
	private float groundHorizontalLength;
	private float localScaleImg;

	// Use this for initialization
	void Start () {
		groundCollider = GetComponent<BoxCollider2D> ();
		groundHorizontalLength = groundCollider.size.x;
		localScaleImg = transform.localScale.x;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.x < (-groundHorizontalLength * localScaleImg)) {
			RepositionBackground ();
		}
	
	}

	private void RepositionBackground(){
		Vector2 groundOffset = new Vector2 (groundHorizontalLength * 2f * localScaleImg, 0);
		transform.position = (Vector2)transform.position + groundOffset;
	}
}
