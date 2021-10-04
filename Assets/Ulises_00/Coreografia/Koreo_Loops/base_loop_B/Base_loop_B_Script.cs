using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Base_loop_B_Script : MonoBehaviour
{

    public int counter;
    public AudioSource Base_Loop_B;


    CompleteSpawning.EnemySpawning spawncom;

    public bool _spawning;




    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();

        counter = counter;
        Koreographer.Instance.RegisterForEvents("base_loop_B_Spawn", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        --counter;



        if (Base_Loop_B.volume != 0f)
        {



            if (counter % 2 == 0)
            {
                spawncom.Spawning();
   
                spawncom.SpawningThree();
          
            }

            if (counter % 2 == 1)
            {

                spawncom.SpawningTwo();
  
                spawncom.SpawningFour();

            }

            if (counter == 0)
            {
                StartCoroutine(WaitToRestart());
            }
        }



    }

    IEnumerator WaitToRestart()
    {

        yield return new WaitForSeconds(7);
        counter = 16;

    }



    // Update is called once per frame
    void Update()
    {

    }
}