using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	private Rigidbody rb;
	public float playerVelocity = 10f;
	public float jumpForce = 8;

	public LayerMask groundLayer;
	public SphereCollider spherecol;





	// Update is called once per frame
	void Start()
	{
		rb = GetComponent <Rigidbody> ();
		spherecol = GetComponent<SphereCollider> ();
	}


	void FixedUpdate (){

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");


		Vector3 moviment = new Vector3 (moveHorizontal, 0, moveVertical);
		rb.AddForce (moviment* playerVelocity);

		if (IsGrounded() && Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (Vector3.up * jumpForce, ForceMode.Impulse);
		}
	}

	private bool IsGrounded(){
		return	Physics.CheckCapsule (spherecol.bounds.center, new Vector3 (spherecol.bounds.center.x, spherecol.bounds.min.y, spherecol.bounds.center.z), 
			spherecol.radius * .9f, groundLayer);
		
	}

	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag ("PickUp")) {
			other.gameObject.SetActive (false);
			ColoreGM.instance.BallScored ();
		}

			if (ColoreGM.instance.points == 9) {
				ColoreGM.instance.LevelComplete ();
			playerVelocity = 0;		
			jumpForce = 0;
		}
		
	}
}
