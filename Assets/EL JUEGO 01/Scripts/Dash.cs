using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash : MonoBehaviour {

	public Vector3 moveDirection;
	public float maxDashTime = 1.0f;
	public float dashSpeed = 1.0f;
	public float dashStoppingSpeed = 1.0f;

	private float currentDashTime;


	void Start ()
	{
		currentDashTime = maxDashTime;
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.Z)) 
		{
			currentDashTime = 0.9f;
		}
		if (currentDashTime < maxDashTime) {
			moveDirection = new Vector3 (0, 0, dashSpeed);
			currentDashTime += dashStoppingSpeed;

		} else 
		{
			moveDirection = Vector3.zero;

		}

	}
}
