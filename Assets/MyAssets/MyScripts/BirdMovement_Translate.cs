using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement_Translate : MonoBehaviour {


	private int health;
	public float moveSpeed;
	private bool isLightOn;
	private string name = "Liana";

	// Use this for initialization
	void Start () {
		health = 100;
		isLightOn = true;

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			moveBirdUp ();
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			moveBirdLeft ();
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			moveBirdRight ();
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			moveBirdDown ();
		}
		if (Input.GetKey (KeyCode.R)) {
			moveBirdRandom ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			TestFire();
		}

	}

	void moveBirdUp() {
		transform.position = transform.position + new Vector3(0, moveSpeed, 0);
	}

	void moveBirdLeft() {
		transform.position = transform.position + new Vector3(-moveSpeed, 0, 0);
	}

	void moveBirdRight() {
		transform.position = transform.position + new Vector3(moveSpeed, 0, 0);
	}

	void moveBirdDown() {
		transform.position = transform.position + new Vector3(0, -moveSpeed, 0);
	}

	void moveBirdRandom() {
		transform.position = transform.position + new Vector3 (randomFloat(), randomFloat(), randomFloat());
	}

	float randomFloat() {
		return Random.Range (-1f, 1f) / 10f;;
	}

	void TestFire() {
		Debug.Log ("beep");
	}

		
}
