using System.Collections;
using System.Collections.Generic;
using System.Collections;
using UnityEngine;

public class LateralSpawn : MonoBehaviour {

    CompleteSpawning.EnemySpawning spawncom;
    
    
    // Use this for initialization
    void Start () {
       // spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
        InvokeRepeating("SpawnLateral", 3.5f, 0.0f);
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnLatertal()
    {
        
    }
}
