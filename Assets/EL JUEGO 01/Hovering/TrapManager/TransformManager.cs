using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformManager : MonoBehaviour {

	GameObject disparar;
	GameObject cortar;
	GameObject flotar;

	public HovShoot theShoot;
	public Dash3D theDash;
	public ParticulaTrail  theTrail;
	public float theSperas;

	public DestroyTrail theDamageTrail;

	bool cooldown;
	public int n = 0;

	public float cooldownTime = 2;
	private float nextFireTime = 0;

	void Start()
	{
		theShoot = GetComponent<HovShoot>();
		theDash = GetComponent<Dash3D>();
		theTrail = GetComponent<ParticulaTrail>();
		cooldown = false;

		disparar = GameObject.Find ("disparar_01");
		cortar = GameObject.Find ("cortar_01");
		flotar = GameObject.Find ("flotar_01");

		disparar.SetActive (true);
		cortar.SetActive (false);
		flotar.SetActive (false);

		theShoot.enabled = true;
		theDash.enabled = false;
		theTrail.enabled = false;
		theDamageTrail.enabled = true;
	}


	IEnumerator TrapTimer()
	{
		cooldown = true;
		yield return new WaitForSeconds (0f);

		n++;

		if (n == 4) {
			n = 1;
		}

		if (n == 1) {
			theShoot.enabled = false;
			theDash.enabled = true;
			theTrail.enabled = false;
			theDamageTrail.enabled = true;

			disparar.SetActive (false);
			cortar.SetActive (true);
			flotar.SetActive (false);
		


		}

		

			if (n == 2) {
				theShoot.enabled = false;
				theDash.enabled = false;
				theTrail.enabled = true;
				theDamageTrail.enabled = true;

				disparar.SetActive (false);
				cortar.SetActive (false);
				flotar.SetActive (true);
			}

			if (n == 3) {
				theShoot.enabled = true;
				theDash.enabled = false;
				theTrail.enabled = false;
				theDamageTrail.enabled = true;

				disparar.SetActive (true);
				cortar.SetActive (false);
				flotar.SetActive (false);
			}

			cooldown = false;
		}
	


	void Update()
	{
		if  (Time.time > nextFireTime){
		if (Input.GetKeyDown(KeyCode.Space))
		{
			print ("ability used, cooldown started");
			nextFireTime = Time.time + cooldownTime;
			if (!cooldown)
			{
				StartCoroutine(TrapTimer());

			}
		}

	}
	




}
}

