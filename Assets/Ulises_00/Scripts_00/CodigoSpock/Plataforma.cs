using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
		if (other.tag == "Enemigo")
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
