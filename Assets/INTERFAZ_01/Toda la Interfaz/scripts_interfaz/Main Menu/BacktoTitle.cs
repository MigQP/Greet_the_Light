using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BacktoTitle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine("idling");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator idling()
	{
		yield return new WaitForSeconds (180);
		SceneManager.LoadScene (0);
	}
}
