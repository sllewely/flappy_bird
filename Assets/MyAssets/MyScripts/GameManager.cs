using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject birdPrefab;
	public Transform birdSpawnLocation;

	private GameObject birdClone;

	// this is an instance of a script
	public ObstacleSpawner ObstaclesSpawning;

	public GameObject startButton;
	public Text scoreTextComponent;

	private int _birdPoints = 0;
	private float _buttonCooldown = 0;
	public float desiredButtonCooldown;

	bool isAlive = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (_buttonCooldown > 0) {
			_buttonCooldown -= 1 * Time.deltaTime;
		}

		if (isAlive && birdClone == null) {
			EndGame ();
		}
	}

	public void OnStartButtonPush() {
		Debug.Log ("start button pressed");
		if (_buttonCooldown > 0) {
			return;
		}

		if (birdClone == null) {
			_birdPoints = 0;
			birdClone = Instantiate(birdPrefab, birdSpawnLocation);
			startButton.SetActive(false);
			ObstaclesSpawning.enabled = true;
			isAlive = true;
			scoreTextComponent.text =  _birdPoints.ToString();
		}
	}

	void EndGame() {
		Debug.Log ("End game");
		_buttonCooldown = desiredButtonCooldown;
		ObstaclesSpawning.enabled = false;
		DestroyObstacles ();
		isAlive = false;
		startButton.SetActive(true);
	}

	void DestroyObstacles() {
		GameObject[] ObstaclesToBeDestroyed = GameObject.FindGameObjectsWithTag ("ObstacleTag");
		foreach (GameObject obstacle in ObstaclesToBeDestroyed) {
			Destroy (obstacle);
		}
	}

	void AddPoints() {
		_birdPoints++;
		scoreTextComponent.text = _birdPoints.ToString();
	}
}
