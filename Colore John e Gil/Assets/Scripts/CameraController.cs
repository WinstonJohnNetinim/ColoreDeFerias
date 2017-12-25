using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public GameObject player;
	private Vector3 difCameraPlayer;
	// Use this for initialization
	void Start () {
		difCameraPlayer = transform.position - player.transform.position;
	}
	
	// Update is called once per frame
	void LateUpdate () {
		transform.position = player.transform.position + difCameraPlayer;
		
	}
}
