using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public bool isJumping = false; 
	public float speed = 1;
	public float longJump = 10;
	public float shortJump = 8;
	public float gravity = 15;
	private Vector3 moveDirection = Vector3.zero;


	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		if (controller.isGrounded) {
			moveDirection = new Vector3(Input.GetAxis("Horizontal")*2.5f, 0, 0);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= speed;
			if (Input.GetButton ("longJump"))
				startLongJump ();
			if (Input.GetButton ("shortJump"))
				startShortJump ();

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);
	}

	void startShortJump()
	{
		moveDirection.y = shortJump;
	}

	void startLongJump()
	{
		moveDirection.y = longJump;
	}

}
