using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transparence : MonoBehaviour {

	public Transform target;
	public RaycastHit hitpoint = new RaycastHit();


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Physics.Linecast(transform.position, target.transform.position, out hitpoint)){
			Debug.DrawLine(transform.position, target.transform.position);
		}
		
	}
}
