using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticulaTrail : MonoBehaviour
{
	public float lookSpeed = 2.0f;
	Vector3 mousePos; 

	GameObject disparar;
	GameObject cortar;
	GameObject flotar;

	public DamageParticulaTrail  damageTrail;
    public GameObject theParticula;
	public GameObject modelo;
    //public float time;
    public bool isActive = true;
    public Transform trailPoint;


	public float coolDown = 5;
	public float coolDownTimer;

	public HovShoot theShoot;
	Dash3D theDasher;




	public ParticulaTrail  theTrail;
	public DestroyTrail theDamageTrail;


    void Start ()
    {
		flotar = GameObject.Find ("flotar_01");
		disparar = GameObject.Find ("disparar_01");
		cortar = GameObject.Find ("cortar_01");
	
		

		theShoot = GetComponent<HovShoot>();
		theDasher = GetComponent<Dash3D> ();
		theTrail = GetComponent<ParticulaTrail>();




    }

    void Update()
    {

        if (Input.GetButtonDown("Jump"))
        {
            //theParticula.SetActive(true);
			//Destroy(theParticula);
      

			theDasher.enabled = false;
			theShoot.enabled = true;
			theTrail.enabled = false;



        }

		if (coolDownTimer > 0) 
		{
			coolDownTimer -= Time.deltaTime;
		}
		if (coolDownTimer < 0) 
		{
			

			coolDownTimer = 0;

			//Destroy(theParticula);

			theShoot.enabled = true;
			theTrail.enabled = false;
			theDamageTrail.enabled = false;

			theDasher.enabled = false;
			theShoot.enabled = true;
			cortar.SetActive (false);
			disparar.SetActive (true);
			Input.GetMouseButtonUp (0);


		}
		if (coolDownTimer == 0) 
		{
			coolDownTimer = coolDown;
		}

        if (Input.GetButtonDown("Fire2"))
        {
            if (isActive)
            {
                 
				DamageParticulaTrail newTrailPoint = Instantiate (damageTrail, trailPoint.position, trailPoint.rotation) as DamageParticulaTrail; 
				newTrailPoint.transform.parent = modelo.transform;   
            }
        }
			
    
    }
	void mouseLook()
	{
		float h = lookSpeed * Input.GetAxis("Mouse X");
		transform.Rotate(0, h, 0);
	}
}

