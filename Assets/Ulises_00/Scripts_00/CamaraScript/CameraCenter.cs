using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCenter : MonoBehaviour {

	public Transform myCamera;

	public GameObject ship;

	Vector3 direction;

	Vector3 origen;

	public float cameraDistance;

	// Use this for initialization
	void Start () {

		origen = new Vector3 (0, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {

		direction = ship.transform.position;
		transform.position = direction.normalized * cameraDistance;

		transform.LookAt(origen);

	}
}
