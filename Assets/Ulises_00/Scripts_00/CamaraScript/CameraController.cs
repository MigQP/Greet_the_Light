
using UnityEngine;

public class CameraController : MonoBehaviour {
	public Transform target;

	public GameObject ship;

	public Transform myCamera;

	void Update() {

		Vector3 relativePos = target.position - transform.position;	
		Quaternion rotation = Quaternion.LookRotation(relativePos);
		transform.rotation = rotation;

	

	
	}











}
