using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideSpawning : MonoBehaviour {

 
    CompleteSpawning.EnemySpawning spawncom;

    bool _spawning = false;

    public AudioSource _theSpawnerClip;

    public float _interval;

    public bool explode;

    public int counter;


    public int _spawningCounter = 4;
    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
        InvokeRepeating("SideSpawn", 0.0f, _interval);
   
        counter = counter;
        
    }


  


    // Update is called once per frame
    void Update()
    {

    }

    void SideSpawn()
    {
        if (_theSpawnerClip.volume != 0)
        {
            counter--;
            spawncom.Spawning();
            spawncom.SpawningTwo();
            spawncom.SpawningThree();
            spawncom.SpawningFour();
        }

        if (counter == 0)
        {
            CancelInvoke("SideSpawn");
        }
    }

   
}
