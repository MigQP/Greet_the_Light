using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Baj_loop_C_Script : MonoBehaviour
{

    public int counter;
    public AudioSource Baj_Loop_C;


    CompleteSpawning.EnemySpawning spawncom;

    public bool _spawning;




    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();

        counter = counter;
        Koreographer.Instance.RegisterForEvents("baj_loop_C_Spawn", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        --counter;



        if (Baj_Loop_C.volume != 0f)
        {
            if (counter%2 == 0)
            {
                spawncom.SpawningTwo();

              //  spawncom.SpawningFour();

            }

        
    



            if (counter == 0)
            {


                StartCoroutine(WaitToRestart());
            }
        }
        }



    

    IEnumerator WaitToRestart()
    {

        yield return new WaitForSeconds(24.5f);
        counter = 16;

    }



    // Update is called once per frame
    void Update()
    {

    }
}