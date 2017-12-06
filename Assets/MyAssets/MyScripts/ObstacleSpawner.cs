using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {

	public float spawnDelay;

	private float _spawnDelayInScript;

	public GameObject obstaclePrefab;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		_spawnDelayInScript -= 1 * Time.deltaTime;

		if (_spawnDelayInScript < 0) {
			SpawnObstacle ();

			_spawnDelayInScript = spawnDelay;
		}
	}

	void SpawnObstacle() {
		GameObject ObstacleClone;

		Vector3 randomHeightVector = new Vector3 (10, Random.Range(-2f, 2f), 0);

		ObstacleClone = Instantiate (obstaclePrefab, randomHeightVector, Quaternion.identity);
	}
}
