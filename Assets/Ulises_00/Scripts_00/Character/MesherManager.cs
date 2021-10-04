using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesherManager : MonoBehaviour {

	public GameObject objectToDisable;
	public static bool disabled = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (disabled)
			objectToDisable.SetActive (false);
		else
			objectToDisable.SetActive (true);

		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			objectToDisable.SetActive (true);
		}
	
	}
}
