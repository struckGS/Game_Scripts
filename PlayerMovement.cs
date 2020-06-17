using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	public CharacterController controller;
	public float speed = 12f;
	public float jumpSpeed = 5f;
	Vector3 velocity;
	public float gravity = -15f;
	bool isGrounded;
	public Transform groundcheck;
	public LayerMask groundLayer;
	float radius = 0.4f;
	public GameObject respawnMenu;
	// Update is called once per frame
	void Update()
	{
		isGrounded = Physics.CheckSphere(groundcheck.position, radius, groundLayer);
		if (isGrounded && velocity.y < 0)
		{
			velocity.y = -2f;
		}

		float x = Input.GetAxis("Horizontal");
		float z = Input.GetAxis("Vertical");
		Vector3 move = transform.right * x + transform.forward * z;
		controller.Move(move * speed * Time.deltaTime);

		// This if statement contains the code for jumping
		if (Input.GetButtonDown("Jump") && isGrounded)
		{
			velocity.y = Mathf.Sqrt(jumpSpeed * -2f * gravity);
		}

		velocity.y += gravity * Time.deltaTime;
		controller.Move(velocity * Time.deltaTime);	

	}
}
