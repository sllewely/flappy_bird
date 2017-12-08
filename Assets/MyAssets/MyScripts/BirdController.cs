﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

	public Rigidbody2D myBirdsRigid;
	public float upForce;

	// Use this for initialization
	void Start () {
		
	}

	void Update() {
		if (transform.position.y < -5.5) {
			Destroy (gameObject);
		}
	}
	
	// Called a fixed number per time
	// Used for physics
	void FixedUpdate () {

		if (Input.GetKeyDown (KeyCode.Space)) {
//			myBirdsRigid.AddForce (Vector2.up * upForce);
			myBirdsRigid.velocity = (Vector2.up * upForce);
		}
		
	}

	void OnCollisionEnter2D(Collision2D objectBeingHit) {
		Debug.Log ("I hit " + objectBeingHit.gameObject.name);

		Destroy (gameObject);
	}

	void OnTriggerEnter2D() {
		GameObject thisIsGameLogicGameObject = GameObject.Find ("GameLogic");

		thisIsGameLogicGameObject.BroadcastMessage ("AddPoints");
	}
}
