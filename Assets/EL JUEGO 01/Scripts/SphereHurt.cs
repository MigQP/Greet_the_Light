using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereHurt : MonoBehaviour {

	void OnTriggerEnter (Collider other)
	{
		if (other.tag == "Enemigo")
		{
			Destroy (gameObject);
		}
	}
}
