using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class SpawnOnTime : MonoBehaviour
{

    int n = 0;

    public bool _changeSpawning = false;

    CompleteSpawning.EnemySpawning spawncom;




    // Use this for initialization
    void Start()
    {


        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
        Koreographer.Instance.RegisterForEvents("spawn", OnMusicalShoot);
      


    }

    void OnMusicalShoot(KoreographyEvent evt)
    {

     


        if (evt.Payload is IntPayload)
        {


            n++;
            if (n == 0)
            {
                spawncom.Spawning();
            }
            if (n == 1)
            {
           
            }

            if (n == 2)
            {
                spawncom.Spawning();
                n = 1;
            }

            Debug.Log(n);

        }
            

            //     _changeSpawning = false;
            //    spawncom.SpawningTwo();
        

        if (evt.Payload is FloatPayload)
        {
           _changeSpawning = false;
            spawncom.SpawningThree();
        }

    


    }
}
