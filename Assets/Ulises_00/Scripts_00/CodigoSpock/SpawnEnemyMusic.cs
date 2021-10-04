using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class SpawnEnemyMusic : MonoBehaviour
{
    public AudioSource Audio_Agu_Loop_G;

    int n = 0;
    public float _numeroEnemigo = 5;
    public bool _changeSpawning = false;

    CompleteSpawning.EnemySpawning spawncom;




    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
        Koreographer.Instance.RegisterForEvents("segundo_loop", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
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

            if (n == _numeroEnemigo)
            {
          
            }
            Debug.Log(n);

        }

    // Update is called once per frame
    void Update()
    {

    }
}