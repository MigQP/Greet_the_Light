using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Medios_loop_C_Script : MonoBehaviour
{

    public AudioSource Audio_Medios_Loop_C;
    int n = 0;
    CompleteSpawning.EnemySpawning spawncom;

    bool _spawning = false;

    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
        Koreographer.Instance.RegisterForEvents("medios_loop_C_Spawn", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        n++;
        if (Audio_Medios_Loop_C.volume != 0f)
        {

            _spawning = true;

            if (_spawning)
                spawncom.SpawningTwo();
           // spawncom.SpawningFour();
        }




        if (Audio_Medios_Loop_C.volume == 0f)
        {
            _spawning = false;
        }

        if ( n == 1)
        {
            spawncom.SpawningFour();
        }
        if (n == 3)
        {
            spawncom.SpawningFour();
        }


        if (n == 4)
        {
            _spawning = false;
            n =0;
        }
        Debug.Log(n);

        if (evt.Payload is FloatPayload)
        {

        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
