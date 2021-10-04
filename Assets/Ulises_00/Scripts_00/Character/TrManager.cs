using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrManager : MonoBehaviour {

    trdController controller;

    public GameObject ShootMesh;
	public GameObject DashMesh;
	public GameObject TrailMesh;

	public HovShoot theShoot;
	public Dash3D theDash;
	public ParticulaTrail theTrail;
	public float theSperas;

	public DestroyTrail theDamageTrail;

	bool cooldown;
	private int n = 0;


    float initialSpeed;
    float movingSpeed;


    public float coolDown = 5;
	public float coolDownTimer;

	public float seccoolDown = 10;
	public float seccoolDownTimer;

	bool timest = false;

	void Start()
	{
		ShootMesh = GameObject.Find("disparar_01");
		DashMesh = GameObject.Find("cortar_01");
		TrailMesh = GameObject.Find("flotar_01");

        controller = GetComponent<trdController>();

        theShoot = GetComponent<HovShoot>();
		theDash = GetComponent<Dash3D>();
		theTrail = GetComponent<ParticulaTrail>();
		cooldown = false;
		DashMesh.SetActive(false);
		TrailMesh.SetActive(false);

        movingSpeed = controller.movingSpeed;
        initialSpeed = movingSpeed;
    }


	IEnumerator TrapTimer()
	{
		cooldown = true;
		yield return new WaitForSeconds(theSperas);
		n++;

		if (n == 4)
		{
			n = 1;
		}

		if (n == 1)
		{
			
			//theSperas = 0;

			ShootMesh.SetActive(false);
			DashMesh.SetActive(true);
			TrailMesh.SetActive(false);
			//timest = true;
            TransBar.trans = coolDownTimer;
            
        }

		if (n == 2)
		{
			
			//theSperas = 0;

			ShootMesh.SetActive(false);
			DashMesh.SetActive(false);
			TrailMesh.SetActive(true);
            TransBar1.trans1 = seccoolDownTimer;
            controller.movingSpeed = initialSpeed;

        }

		if (n == 3)
		{
			

			ShootMesh.SetActive(true);
			DashMesh.SetActive(false);
			TrailMesh.SetActive(false);
            TransBar.trans = coolDownTimer;
            controller.movingSpeed = initialSpeed;
        }

	
		cooldown = false;
	}


	void Update()
	{
        if (Input.GetButtonDown("Jump"))
        {
			if (!cooldown)
			{
				StartCoroutine(TrapTimer());

			}
		}
		if (n == 1)
		{
		if (coolDownTimer > 0) 
		{
			coolDownTimer -= Time.deltaTime;
            TransBar.trans -= Time.deltaTime;
		}
		if (coolDownTimer < 0) 
		{


			coolDownTimer = 0;
			ShootMesh.SetActive(true);
			DashMesh.SetActive(false);
			TrailMesh.SetActive(false);
                

                n = 0;

		}
		if (coolDownTimer == 0) 
		{
            controller.movingSpeed = initialSpeed;
			coolDownTimer = coolDown;
            TransBar.trans = coolDown;
		}

	}
		if (n == 2) 
		{
			if (seccoolDownTimer > 0) 
			{
				seccoolDownTimer -= Time.deltaTime;
                TransBar1.trans1 -= Time.deltaTime;
            }
			if (seccoolDownTimer < 0) 
			{


				seccoolDownTimer = 0;
				ShootMesh.SetActive(true);
				DashMesh.SetActive(false);
				TrailMesh.SetActive(false);
                

                n = 0;

			}
			if (seccoolDownTimer == 0) 
			{
                controller.movingSpeed = initialSpeed;
				seccoolDownTimer = seccoolDown;
                TransBar1.trans1 = seccoolDown;
            }

		}
}
}
