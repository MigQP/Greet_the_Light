using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ubicacion : MonoBehaviour {


    //public transform firepoint;
    public GameObject ObjetoPrueba;

    private int n = 0;

	// Update is called once per frame
	void Update ()

    {
		


	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            n++;
            Debug.Log ("Averscierto");
            Debug.Log(n);
        }

        if (n == 1)
        {

                { 
                Instantiate(ObjetoPrueba, transform.position, transform.rotation);
                Destroy(gameObject);
            }
        }
    }
}
