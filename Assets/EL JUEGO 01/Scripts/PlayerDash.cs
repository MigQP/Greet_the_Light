using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerDash : MonoBehaviour {
	public float moveSpeed;
	private Rigidbody myRigidbody;

	private Vector3 moveInput;
	private Vector3 moveVelocity;

	private Camera mainCamera;



	void Start ()
	{
		myRigidbody = GetComponent<Rigidbody>();
		mainCamera = FindObjectOfType<Camera>();

	
	}

	void Update ()
	{
		moveInput = new Vector3 (Input.GetAxisRaw ("Horizontal") , 0f, Input.GetAxisRaw("Vertical"));
		moveVelocity = moveInput * moveSpeed;

		Ray cameraRay = mainCamera.ScreenPointToRay (Input.mousePosition);
		Plane groundPlane = new Plane (Vector3.up, Vector3.zero);
		float rayLength;	

		if (groundPlane.Raycast(cameraRay, out rayLength))
		{
			Vector3 pointToLook = cameraRay.GetPoint(rayLength);	
			Debug.DrawLine (cameraRay.origin, pointToLook, Color.blue);
			transform.LookAt (new Vector3 (pointToLook.x, transform.position.y,pointToLook.z));
		}

		if (Input.GetMouseButtonDown (0)) 
		{
			
			GetComponent<Rigidbody> ().AddForce (moveVelocity * 1000);	
			GetComponent<Collider>().isTrigger = true;
			Debug.Log ("SE ACTIVO EL TRIGGER");

		}

		if (Input.GetMouseButtonUp (0)) 
		{
			GetComponent<Collider>().isTrigger = false;
		}

		Scene currentScene = SceneManager.GetActiveScene ();
		string sceneName = currentScene.name;

		if (GameObject.FindWithTag ("Enemigo") == null) 
		{
			if (sceneName == "escena_04") 
			{
				SceneManager.LoadScene (3);
			}

			if (sceneName == "escena_02") 
			{
				SceneManager.LoadScene (2);
			}
			if (sceneName == "escena_08") 
			{
				SceneManager.LoadScene (0);
			}


		}

	}

	void FixedUpdate ()
	{
		myRigidbody.velocity = moveVelocity;
	}

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Enemigo") 
		{
			Destroy (other.gameObject);
		}
	}


}
