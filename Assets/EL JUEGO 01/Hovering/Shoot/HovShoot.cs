using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using XInputDotNetPure;


public class HovShoot : MonoBehaviour {

	//1.25 s  entre disparos
	public GunController theGun;
	public GunController ndGun;

    //bool playerIndexSet = false;
    //PlayerIndex playerIndex;
   // GamePadState state;
    //GamePadState prevState;

    GameObject disparar;
	GameObject cortar;
	GameObject flotar;


	int p = 0;
	public ParticulaTrail  theTrail;
	public DestroyTrail theDamageTrail;

	public HovShoot theShoot;
	Dash3D theDasher;

    
	void Awake () {
			
	}
	void Start () {
      
		disparar = GameObject.Find ("disparar_01");
		cortar = GameObject.Find ("cortar_01");
		flotar = GameObject.Find ("flotar_01");

		theShoot = GetComponent<HovShoot>();
		theDasher = GetComponent<Dash3D> ();
		theTrail = GetComponent<ParticulaTrail>();
    }

    void FixedUpdate()
    {
        //GamePad.SetVibration(playerIndex, state.Triggers.Left, state.Triggers.Right); 
    }

    void Update ()

    {
        
        if (Input.GetAxisRaw("Fire1") != 0 )
        {
			//FMOD.Studio.EventInstance PlayGunSound;
			//PlayGunSound = FMODUnity.RuntimeManager.CreateInstance ("event:/Hey");
			//PlayGunSound.start ();
			theGun.isFiring = true;
			ndGun.isFiring = true;

            //if (!playerIndexSet || !prevState.IsConnected)
            //{
               // for (int i = 0; i < 4; ++i)
              //  {
                //    PlayerIndex testPlayerIndex = (PlayerIndex)i;
                //    GamePadState testState = GamePad.GetState(testPlayerIndex);
                //    if (testState.IsConnected)
                 //   {
                 //       Debug.Log(string.Format("GamePad found {0}", testPlayerIndex));
                 //       playerIndex = testPlayerIndex;
                 //       playerIndexSet = true;
                 //   }
              //  }
            //}
            //prevState = state;
            //state = GamePad.GetState(playerIndex);
        }

        if (Input.GetAxisRaw("Fire1") == 0)
        {
			theGun.isFiring = false;
			ndGun.isFiring = false;
		
		}
        if (Input.GetButtonDown("Jump"))
        {
			
				theGun.isFiring = false;
				theDasher.enabled = true;
				theShoot.enabled = false;


		
		
		}

			
    }
	}
	
