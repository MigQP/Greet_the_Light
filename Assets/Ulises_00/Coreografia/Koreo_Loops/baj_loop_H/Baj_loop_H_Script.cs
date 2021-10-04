using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Baj_loop_H_Script : MonoBehaviour
{

    public int counter;
    public AudioSource Baj_Loop_H;


    CompleteSpawning.EnemySpawning spawncom;

    public bool _spawning;




    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();

        counter = counter;
        Koreographer.Instance.RegisterForEvents("baj_loop_H", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        --counter;



        if (Baj_Loop_H.volume != 0f)
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