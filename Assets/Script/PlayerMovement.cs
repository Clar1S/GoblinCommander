using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float move;
	public float jump;

	public CharacterController controller;

	private Vector3 moveDirection;
	public float gravity;

	public Rigidbody rb;

	private Animator anim;

	// Use this for initialization
	void Start () {
		controller = GetComponent<CharacterController> ();
		anim = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		if (controller.isGrounded)
		{
			moveDirection = new Vector3(0, 0, Input.GetAxis("Vertical"));
			moveDirection = Vector3.ClampMagnitude (moveDirection, 1);
			moveDirection = transform.TransformDirection(moveDirection);
			moveDirection *= move;
			if (Input.GetButton("Jump"))
				moveDirection.y = jump;

		}
		moveDirection.y -= gravity * Time.deltaTime;
		controller.Move(moveDirection * Time.deltaTime);

		//Rotate Player
		transform.Rotate(0, Input.GetAxis("Horizontal"), 0);

		//Trigger Game Over
		if (rb.position.y < 0.1f) {
			FindObjectOfType<GameManager> ().GameOver ();
		}



	}
	//Exit Game
	public void exitGame(){
		if(Input.GetKey("Escape")) {
			Application.Quit();
		}
	}
}