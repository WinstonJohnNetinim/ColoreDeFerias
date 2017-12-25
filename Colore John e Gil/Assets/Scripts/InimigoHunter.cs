using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class InimigoHunter : MonoBehaviour {

	public float patrolDistance = 30;
	private GameObject player;
	private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");
		agent = GetComponent <NavMeshAgent> ();
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (Vector3.Distance (player.transform.position, agent.transform.position) < patrolDistance) {
			agent.destination = player.transform.position;
		}
	}
}
