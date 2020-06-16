using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 12f;
	public float jumpSpeed = 400f;
	Vector3 velocity;
	public float gravit = 5f;
	// Update is called once per frame
	void Update()
	{
		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		Vector3 move = transform.right * x + transform.forward * z;
		controller.Move(move * speed * Time.deltaTime);
		velocity.y -= gravity * Time.deltaTime;

		controller.Move(velocity * Time.deltaTime);
		
		// This if statement contains the code for jumping
		if (controller.isGrounded & Input.GetButton("Jump"))
		{
			velocity.y += jumpSpeed * Time.deltaTime;
			controller.Move(velocity * Time.deltaTime);
		}

	}
}
