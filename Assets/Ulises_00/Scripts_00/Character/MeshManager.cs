using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeshManager : MonoBehaviour {

	GameObject disparar;
	GameObject cortar;
	GameObject flotar;

	public HovShoot theShoot;

	int p = 0;
	// Use this for initialization
	void Start () {
		disparar = GameObject.Find ("disparar_01");
		cortar = GameObject.Find ("cortar_01");
		flotar = GameObject.Find ("flotar_01");
		disparar.SetActive (true);
		cortar.SetActive (false);
		flotar.SetActive (false);
		theShoot = GetComponent<HovShoot>();	

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Space)) 
		{
			p++;
		}

		if (p == 1) 
		{
			cortar.SetActive (true);
			disparar.SetActive (false);
			flotar.SetActive (false);
		}
		if (p == 2)
		{
			flotar.SetActive (true);
			disparar.SetActive (false);
			cortar.SetActive (false);
		}
		if (p == 3)
		{
			disparar.SetActive (true);
			cortar.SetActive (false);
			flotar.SetActive (false);
		}

		if (p == 4) 
		{
			p = 1;
		}


	}
}
