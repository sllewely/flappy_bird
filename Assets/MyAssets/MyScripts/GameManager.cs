using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject birdPrefab;
	public Transform birdSpawnLocation;

	// Use this for initialization
	void Start () {
		SpawnBird ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			SpawnBird ();
		}
		
	}

	void SpawnBird() {
		Instantiate (birdPrefab, birdSpawnLocation);
	}
}
