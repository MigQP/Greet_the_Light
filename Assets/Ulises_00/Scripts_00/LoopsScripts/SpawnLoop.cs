using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;


public class SpawnLoop : MonoBehaviour
{ 
        int n = 0;


    public AudioSource _theLineLoop;

CompleteSpawning.EnemySpawning spawncom;




// Use this for initialization
void Start()
{
    spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
    Koreographer.Instance.RegisterForEvents("linespawn", OnMusicalShoot);

}


void Update()
{

}

void OnMusicalShoot(KoreographyEvent evt)
{


    if (_theLineLoop.volume != 0f)
    {

        spawncom.SpawningThree();
    }

    if (evt.Payload is IntPayload)
    {

        if (n == 0 && _theLineLoop.volume != 0f)
        {
            spawncom.SpawningThree();
        }
        n++;
        if (n == 1)
        {

        }

        if (n == 2 && _theLineLoop.volume != 0f)
        {
            spawncom.SpawningThree();
            n = 1;
        }



    }




    if (evt.Payload is FloatPayload)
    {

    }




}
}