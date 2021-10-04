using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyParticula : MonoBehaviour {

    public float lifeTime;
    public GameObject theParticula;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
        {
            Destroy(theParticula);
        }
    }
}
