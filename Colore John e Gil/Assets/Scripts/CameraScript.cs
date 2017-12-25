using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour {

	public Transform target;
	public Vector3 offset;
	private Vector3 rotationPosition;

	// Use this for initialization
	void Start () {
		rotationPosition = offset;
	}
	
	// Update is called once per frame
	void Update () {
		transform.eulerAngles = transform.eulerAngles + Vector3.up * Input.GetAxis("Horizontal");
		rotationPosition = new Vector3 (offset.z * Mathf.Sin (transform.eulerAngles.y / 57.3f) , offset.y, offset.z * Mathf.Cos (transform.eulerAngles.y / 57.3f));
		transform.position = target.position + rotationPosition;
	}
}
