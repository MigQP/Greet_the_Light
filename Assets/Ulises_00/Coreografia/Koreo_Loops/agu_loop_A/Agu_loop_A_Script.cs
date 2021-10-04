using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;


public class Agu_loop_A_Script : MonoBehaviour
{
    public int counter;
    public AudioSource Agu_Loop_A;


    CompleteSpawning.EnemySpawning spawncom;

    public bool _spawning;




    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();

        counter = counter;
        Koreographer.Instance.RegisterForEvents("agu_loop_A_Spawn", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        --counter;



        if (Agu_Loop_A.volume != 0f)
        {




            if (counter == 0)
            {
                spawncom.Spawning();

                spawncom.SpawningFour();

                StartCoroutine(WaitToRestart());
            }
        }



    }

    IEnumerator WaitToRestart()
    {

        yield return new WaitForSeconds(10.5f);
        counter = 1;

    }



    // Update is called once per frame
    void Update()
    {

    }
}