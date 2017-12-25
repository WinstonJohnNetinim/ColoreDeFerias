using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour {

	public GameObject player;

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Enemies")) {
			other.gameObject.SetActive (true);
				player.gameObject.SetActive (false);
				ColoreGM.instance.BallDied ();

		}

	}
}
