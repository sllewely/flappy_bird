using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject birdPrefab;
	public Transform birdSpawnLocation;

	private GameObject birdClone;

	// this is an instance of a script
	public ObstacleSpawner ObstaclesSpawning;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			SpawnBird ();
		}

		if (birdClone != null) {
			ObstaclesSpawning.enabled = true;
		} else {
			ObstaclesSpawning.enabled = false;
			DestroyObstacles ();
		}
	}

	void SpawnBird() {
		birdClone = Instantiate (birdPrefab, birdSpawnLocation);
	}

	void DestroyObstacles() {
		GameObject[] ObstaclesToBeDestroyed = GameObject.FindGameObjectsWithTag ("ObstacleTag");
		foreach (GameObject obstacle in ObstaclesToBeDestroyed) {
			Destroy (obstacle);
		}
	}
}
