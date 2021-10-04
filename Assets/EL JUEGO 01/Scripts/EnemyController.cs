using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

	private Rigidbody myRB;
	public float moveSpeed;

	private Controller theController;



	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody>();
		theController = FindObjectOfType<Controller> ();
			
	}

	void FixedUpdate ()
	{
		myRB.velocity = (transform.forward * moveSpeed);
	}
	// Update is called once per frame
	void Update () {
		transform.LookAt (theController.transform.position);
	}
}
