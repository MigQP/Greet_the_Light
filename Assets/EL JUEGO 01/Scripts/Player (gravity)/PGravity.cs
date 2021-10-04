using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PGravity : MonoBehaviour {

	public float speed = 1.0f;
	public float gravity = 9.98f;
	public Transform gravitySource;
	public Rigidbody rb;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		Vector3 gravityVector = (gravitySource.position - transform.position).normalized*gravity;
		rb.AddForce(gravityVector*Time.deltaTime);
		transform.rotation = Quaternion.LookRotation (transform.forward, -gravityVector);

	}
}
