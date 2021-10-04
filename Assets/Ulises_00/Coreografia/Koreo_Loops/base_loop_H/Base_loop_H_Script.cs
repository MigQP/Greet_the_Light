using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Base_loop_H_Script : MonoBehaviour
{

    public AudioSource Audio_Base_Loop_H;
    int n = 0;
    CompleteSpawning.EnemySpawning spawncom;

    bool _spawning = false;

    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
        Koreographer.Instance.RegisterForEvents("base_loop_H_Spawn", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        n++;
        if (Audio_Base_Loop_H.volume != 0f)
        {

            _spawning = true;

            if (_spawning)
                spawncom.Spawning();
        }




        if (Audio_Base_Loop_H.volume == 0f)
        {
            _spawning = false;
        }


        if (n == 4)
        {
            _spawning = false;
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