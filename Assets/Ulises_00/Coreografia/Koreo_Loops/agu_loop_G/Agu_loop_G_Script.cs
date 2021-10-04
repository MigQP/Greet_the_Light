using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Agu_loop_G_Script : MonoBehaviour
{
    public int counter;
    public AudioSource Audio_Agu_Loop_G;
   

    CompleteSpawning.EnemySpawning spawncom;

    public bool _spawning;


  

// Use this for initialization
void Start()
{
    spawncom = GetComponent<CompleteSpawning.EnemySpawning>();

        counter = counter;
        Koreographer.Instance.RegisterForEvents("agu_loop_G_spawn_01", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        --counter;



        if (Audio_Agu_Loop_G.volume != 0f)
        {



            if (counter == 2)
            {
                spawncom.Spawning();
                spawncom.SpawningTwo();
                spawncom.SpawningThree();
                spawncom.SpawningFour();
            }

            if (counter == 0)
            {
                spawncom.Spawning();
                spawncom.SpawningTwo();
                spawncom.SpawningThree();
                spawncom.SpawningFour();

                StartCoroutine(WaitToRestart());
            }
        }



    }

   IEnumerator WaitToRestart()
    {

        yield return new WaitForSeconds(32);
        counter = 4;

    }

 

// Update is called once per frame
void Update()
{
     
    }
}
