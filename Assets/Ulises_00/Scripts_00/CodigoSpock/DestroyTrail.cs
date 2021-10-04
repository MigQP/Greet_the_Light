using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyTrail : MonoBehaviour
{
    bool cool;
    public GameObject theParticula;
    //public ParticulaTrail laParticula;
    public float time;

    // Use this for initialization
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //theParticula.SetActive(false);            
            Destroy(theParticula , time);
            //isActive = false;
        }
    }
}
