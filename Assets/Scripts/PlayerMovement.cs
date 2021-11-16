using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	// Character movement speed.
	public float speed = 5f;

	// Creating a rigid body object. (Don't know what this is yet)
	Rigidbody myRigidBody;

	// Start is called before the first frame update
	// This method is called when the player (sphere) is created.
	void Start()
	{
		myRigidBody = GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update()
	{
		/// Does the player press forward and backward?
		float moveVertical = Input.GetAxis("Vertical");
		/// Does the player press right or left?
		float moveHorizontal = Input.GetAxis("Horizontal");

		// Movement vector for moving vertical x, and horizontal z
		Vector3 movement = new Vector3(moveHorizontal, 0f, moveVertical);

		// We will move player
		myRigidBody.AddForce(movement * speed);
	}
}
