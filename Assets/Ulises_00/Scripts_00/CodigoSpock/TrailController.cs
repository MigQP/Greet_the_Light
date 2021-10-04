using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrailController : MonoBehaviour {


    public ParticulaTrail theParticle;

	// Use this for initialization
	void Update()
    {
        theParticle.isActive = true;
    }
	
	// Update is called once per frame
	//void Update ()
    //{
	
       // if (Input.GetMouseButtonDown(0))
       // {
        //    theParticle.isActive = true;
        //}

        //if (Input.GetMouseButtonUp (0))
       // {
        //    theParticle.isActive = false;
        //}

   // }
}
