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
		transform.Translate (Vector3.up * moveSpeed);
	}

	void moveBirdLeft() {
		transform.Translate (Vector3.left * moveSpeed);
	}

	void moveBirdRight() {
		transform.Translate (Vector3.right * moveSpeed);
	}

	void moveBirdDown() {
		transform.Translate (Vector3.down * moveSpeed);
	}

	void moveBirdRandom() {
		transform.Translate(new Vector3 (randomFloat(), randomFloat(), randomFloat()));
	}

	float randomFloat() {
		return Random.Range (-1f, 1f) / 10f;;
	}

	void TestFire() {
		Debug.Log ("beep");
	}

		
}
