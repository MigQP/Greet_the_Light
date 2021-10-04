using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour {

	[SerializeField]
	public bool getKey = false;

	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Player"))
        {
			Destroy(this.gameObject);
		}
	}
}
