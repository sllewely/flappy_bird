using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour {

	public Rigidbody2D myBirdsRigid;
	public float upForce;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown (KeyCode.Space)) {
			myBirdsRigid.AddForce (Vector2.up * upForce);
		}
		
	}
}
