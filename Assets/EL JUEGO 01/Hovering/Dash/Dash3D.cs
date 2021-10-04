using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dash3D : MonoBehaviour {

    trdController controller;

	GameObject disparar;
	GameObject cortar;
	GameObject flotar;

	public ParticulaTrail  theTrail;
	public HovShoot theShoot;
	public Dash3D theDasher;
	public Rigidbody PlayerRB;
    public float Dash;
    public float dashPower;
    public bool isDash;
    float movingSpeed;
    float initialSpeed;
	public float coolDown = 3;
	public float coolDownTimer;

	// Use this for initialization
	void Start () {
		
        controller = GetComponent<trdController>();
            movingSpeed = controller.movingSpeed;
        initialSpeed = movingSpeed;

		disparar = GameObject.Find ("disparar_01");
		cortar = GameObject.Find ("cortar_01");
		flotar = GameObject.Find ("flotar_01");
		theShoot = GetComponent<HovShoot>();
		theDasher = GetComponent<Dash3D> ();

	

		theTrail = GetComponent<ParticulaTrail>();



	}
    void Update()
    {


        if (coolDownTimer > 0)
        {
            coolDownTimer -= Time.deltaTime;
        }
        if (coolDownTimer < 0)
        {
            coolDownTimer = 0;

            theDasher.enabled = false;
            theShoot.enabled = true;


            theTrail.enabled = false;


            disparar.SetActive(true);
            flotar.SetActive(false);
            cortar.SetActive(false);






        }
        if (coolDownTimer == 0)
        {
            coolDownTimer = coolDown;
        }


        if (Input.GetAxis("Fire1") != 0)
        {
            if (controller.movingSpeed <= initialSpeed)
            {
                controller.movingSpeed *= dashPower;
                isDash = true;

            }
            //GetComponent<Rigidbody> ().AddForce (transform.forward * Dash	);	
            //GetComponent<Collider>().isTrigger = true;
            //Debug.Log ("SE ACTIVO EL TRIGGER");
            //theAeon.enabled = false;
            //FMOD.Studio.EventInstance PlayDashSound;
            //PlayDashSound = FMODUnity.RuntimeManager.CreateInstance ("event:/Dash");
            //PlayDashSound.start ();
        }
        if (Input.GetAxisRaw("Fire1") != 1)

        {
            isDash = false;
            
        }

        if (Input.GetButtonDown("Jump"))
        {

            theDasher.enabled = false;
            theTrail.enabled = true;

            theShoot.enabled = false;
            theDasher.enabled = false;
            isDash = false;
        }

        if (controller.movingSpeed >= initialSpeed)
        {
            controller.movingSpeed -= 0.1f;
        }
        else controller.movingSpeed = initialSpeed;
	}
    private void OnCollisionEnter(Collision other)
    {
        if (isDash == true)           
        {
            if (other.gameObject.CompareTag("Enemigo"))
            {
                Destroy(other.gameObject);
            }
        }
    }
}
