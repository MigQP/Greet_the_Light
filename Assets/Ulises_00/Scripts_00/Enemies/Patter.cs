using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patter : MonoBehaviour {

	public float movingSpeed;	

	bool _verticalLeft = false;
	bool _verticalRight = false;

	bool up = false;

	int backtime = 2;

	bool _horizontalUp = false;
	bool _horizontalDown = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		newMovment();

		StartCoroutine(patron());
	

	}

	void newMovment() 
	{
		if (Input.GetAxisRaw("Vertical") < 0)
		{
			// print("w");
			_verticalRight  = true;
			_verticalLeft = false;
		}

		if (Input.GetAxisRaw("Vertical") > 0)
		{
			//print("s");
			_verticalLeft  = true;
			_verticalRight  = false;
		}

		if (Input.GetAxisRaw("Vertical") == 0)
		{
			_verticalLeft = false;
			_verticalRight  = false;
		}
		if (Input.GetAxisRaw("Horizontal") > 0)
		{
			_horizontalDown  = true; 
			_horizontalUp  = true;
			_horizontalDown  = false;

		}

		if (Input.GetAxisRaw("Horizontal") == 0)
		{
			_horizontalDown  = false;
			_horizontalUp  = false;
		}

	
	}

	IEnumerator patron()
	{
		



			transform.position += transform.forward * movingSpeed;	
		

		yield return new WaitForSeconds(backtime);

		 movingSpeed *= -1;	
		backtime += 2;


	

 


	



	}
}
