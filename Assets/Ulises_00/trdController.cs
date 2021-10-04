using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trdController : MonoBehaviour {
	public Transform myCamera;
	public float lookSpeed = 2.0f;
	public float movingSpeed;
	Vector3 mousePos;

	bool _horizontalUp = false;
	bool _horizontalDown = false;

	bool _verticalLeft = false;
	bool _verticalRight = false;

	//MAIN

	void Update() {
		//KBController();

		newMovment();
		//mouseLook();


	}

	//MISC

	void KBController()
	{
		if (Input.GetKey("w"))
		{

			print("w");
			transform.position += transform.forward * movingSpeed;
		}

		if (Input.GetKey("a")) {
			print("a");
			transform.position -= transform.right * movingSpeed;
		}

		if (Input.GetKey("s")) {
			print("s");
			transform.position -= transform.forward * movingSpeed;
		}

		if (Input.GetKey("d")) {
			print("d");
			transform.position += transform.right * movingSpeed;
		}
	}

	void newMovment() {
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			// print("w");
			_verticalRight  = true;
			_verticalLeft = false;
		}

		if (Input.GetAxisRaw("Vertical") > 0)
		{
			//print("s");
			_verticalLeft  = true;
			_verticalRight  = false;
		}

		if (Input.GetAxisRaw("Vertical") == 0)
		{
			_verticalLeft = false;
			_verticalRight  = false;
		}

		if (_verticalLeft)
		{
			transform.position += myCamera.up * movingSpeed;
		}

		if (_verticalRight)
		{
			transform.position -= myCamera.up * movingSpeed;
		}

		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			_horizontalDown  = true;
			_horizontalUp  = false;

		}

		if (Input.GetAxisRaw("Horizontal") < 0)
		{
			_horizontalUp  = true;
			_horizontalDown  = false;

		}

		if (Input.GetAxisRaw("Horizontal") == 0)
		{
			_horizontalDown  = false;
			_horizontalUp  = false;
		}

		if (_horizontalUp)
		{
			transform.position -= myCamera.right * movingSpeed;
		}

		if (_horizontalDown)
		{
			transform.position += myCamera.right * movingSpeed;
		}
	}

	void mouseLook()
	{
		float h = lookSpeed * Input.GetAxis("Mouse X");
		transform.Rotate(0, h, 0);
	}
}
