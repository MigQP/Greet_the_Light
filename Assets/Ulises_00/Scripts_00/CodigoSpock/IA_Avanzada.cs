using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Avanzada : MonoBehaviour
{

    public Transform ship;
    public float speed;
    public float alertDistance;
    public float walkingDistance;
    public float attackingDistance;

    private Animator anim;
    private Vector3 direction;

	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	void Update ()
    {
		

        //ALERTA!!

        if (Vector3.Distance (ship.position, transform.position) < alertDistance && 
            Vector3.Distance (ship.position, transform.position) > walkingDistance )
        {
            anim.SetBool("isAlert", true);
            anim.SetBool("isIdle", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isWalking", false);
        }

        //ATACANDO!!

        else if (Vector3.Distance (ship.position, transform.position) <= walkingDistance)
        {
            direction = ship.position - transform.position;
            direction.y = 0;

            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.9f * Time.deltaTime);
            transform.Translate(0, 0, speed);

            anim.SetBool("isWalking", true);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isAlert", false);
            anim.SetBool("isIdle", false);

            if (direction .magnitude <= attackingDistance )
            {
                anim.SetBool("isAttacking", true);
                anim.SetBool("isWalking", false);
            }
        }

        //IDLE!!

        else if (anim.GetBool("isIdle") == false )
        {
            anim.SetBool("isWalking", false);
            anim.SetBool("isAttacking", false);
            anim.SetBool("isAlert", false);
            anim.SetBool("isIdle", true);
        }
	}
}
