using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Rebote : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    public bool bouncing;

  void Start()
    {
      
    }


    void FixedUpdate()
    {
         rb.transform.position += transform.forward * thrust;
    }

    void OnCollisionEnter(Collision other)
    {

        if (bouncing == true)
        {

            if (other.gameObject.tag == "Enemigo")
            {
                //thrust = -Mathf.Abs(thrust);
                thrust = thrust * -1;
            }
        }
    }

 
}


