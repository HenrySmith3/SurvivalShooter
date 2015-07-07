using UnityEngine;
using System.Collections;

public class HealthPickup : MonoBehaviour {

	public GameObject player;
	public int pickupValue;
	
	PlayerHealth playerHealth;
	Collider playerCollider;
	Collider collider;
	public Transform[] spawnPoints;
	static Random rnd = new Random();

	// Use this for initialization
	void Start () {
		playerCollider = player.GetComponent <Collider> ();
		playerHealth = player.GetComponent <PlayerHealth> ();
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other){
		if (other == playerCollider) {
			playerHealth.AddHealth(pickupValue);
		}
		gameObject.transform.position = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
	}
}
