using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SndController : MonoBehaviour {


	public float lookSpeed = 2.0f;
	public float movingSpeed;
	Vector3 mousePos;
	public float otherSpeed;



	public Transform modelo;
	public Transform myCamera;

	//MAIN

	void Update() {
		KBController();


		mouseLook();

		transform.position = myCamera.position.normalized * transform.position.magnitude;
	}

	//MISC

	void KBController()
	{
		if (Input.GetKey("a"))
		{

			print("w");
			modelo.Rotate(0,0,- movingSpeed,Space.World);

			//transform.position -= myCamera.right * movingSpeed;
		}

		if (Input.GetKey("s")) {
			print("a");
			modelo.Rotate(movingSpeed,0, 0,Space.World);

			//transform.position -= myCamera.forward * movingSpeed;
		}

		if (Input.GetKey("d")) {
			print("s");
			modelo.Rotate(0,0, movingSpeed,Space.World);
			//transform.position += myCamera.right * movingSpeed;
		}

		if (Input.GetKey("w")) {
			print("d");
			modelo.Rotate(-movingSpeed,0, 0,Space.World);
			//transform.position +=  myCamera.forward * movingSpeed;
		}


			


			




	}



	void mouseLook()
	{
		float h = lookSpeed * Input.GetAxis("Mouse X");
		transform.Rotate(0, h, 0);

	}
}
