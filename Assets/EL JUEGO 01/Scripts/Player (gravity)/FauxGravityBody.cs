using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FauxGravityBody : MonoBehaviour {

	public FauxGravityAttractor attractor;
	private Transform mytransform;



	void Start () {

		mytransform = transform;
	}
	

	void Update () {
		attractor.Attract (mytransform);
	}
}
