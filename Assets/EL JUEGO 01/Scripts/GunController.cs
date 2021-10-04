using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunController : MonoBehaviour {

	public bool isFiring;

	public Arrastre bulletArrastre;
	public float bulletSpeed;

	public float timeBetweenShots;
	private float shotCounter; 

	public Transform firePoint;

    // Use this for initialization
    void Start ()
    {
		
	}

    void FixedUpdate()
    {
      
    }

    // Update is called once per frame
    void Update () {
		if (isFiring) {
			shotCounter -= Time.deltaTime;
			if (shotCounter <= 0) {
				shotCounter = timeBetweenShots;
				Arrastre newBullet = Instantiate (bulletArrastre, firePoint.position, firePoint.rotation) as Arrastre;                      
            }
		} else 
		
		{
			shotCounter = 0;          
        }		
	}
}
