using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdMovement_Translate : MonoBehaviour {

	public float jumpForce;
	public float fakeGravitySpeed;


	private int health;
	private bool isLightOn;
	private string name = "Liana";

	// Use this for initialization
	void Start () {
		health = 100;
		isLightOn = true;

	}
	
	// Update is called once per frame
	void Update () {

		fakeGravity ();

		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			moveBirdUp ();
		}
		if (Input.GetKey (KeyCode.R)) {
			moveBirdRandom ();
		}
		if (Input.GetKeyDown (KeyCode.Space)) {
			TestFire();
		}


	}

	void moveBirdUp() {
		transform.Translate (Vector3.up * jumpForce);
	}

	void moveBirdLeft() {
		transform.Translate (Vector3.left * jumpForce);
	}

	void moveBirdRight() {
		transform.Translate (Vector3.right * jumpForce);
	}

	void moveBirdDown() {
		transform.Translate (Vector3.down * jumpForce);
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

	void fakeGravity() {
		transform.Translate (Vector3.down * fakeGravitySpeed);
	}

		
}
