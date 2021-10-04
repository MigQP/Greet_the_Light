using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aplastar : MonoBehaviour {


    void Update()
    {
        
    }
    void OnCollisionStay (Collision other)
	{
		if (other.gameObject.tag == "Enemigo")
		{
			Debug.Log("ENEMIGO MUERTO");
			Destroy (other.gameObject);
		}
	}
}
