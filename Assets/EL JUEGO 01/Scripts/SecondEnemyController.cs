using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondEnemyController : MonoBehaviour {
	private Rigidbody myRB;
	public float moveSpeed;


	public PlayerDash theDashPlayer;



	// Use this for initialization
	void Start () {
		myRB = GetComponent<Rigidbody>();

		theDashPlayer = FindObjectOfType<PlayerDash> ();

	}

	void FixedUpdate ()
	{
		myRB.velocity = (transform.forward * moveSpeed);
	}
	// Update is called once per frame
	void Update () {
		
		transform.LookAt (theDashPlayer.transform.position);
	}
}
