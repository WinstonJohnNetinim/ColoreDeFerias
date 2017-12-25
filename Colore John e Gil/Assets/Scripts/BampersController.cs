using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BampersController : MonoBehaviour {

	// Use this for initialization
	void Start() 
	{
		gameObject.SetActive (true);
	}
	void Update () {
		transform.Rotate (30 * Time.deltaTime, 45 * Time.deltaTime, 0);
	}
}
