﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour {

	public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (Vector3.left * moveSpeed * Time.deltaTime);

		if (transform.position.x < -15) {
			Destroy (gameObject);
		}
		
	}
}
