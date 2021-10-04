using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateLoop : MonoBehaviour {


	public Animator _pressAnyAnimator;


	// Use this for initialization
	void Start () {

		_pressAnyAnimator = GameObject.FindWithTag ("pressany").GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine("loopeo");

	}

	IEnumerator loopeo ()
	{
		yield return new WaitForSeconds (2);

		_pressAnyAnimator.SetBool ("looping", true);

	}
}

