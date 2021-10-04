using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class Agu_loop_F_Script : MonoBehaviour
{
    public AudioSource Audio_Agu_Loop_F;
    int n = 0;
    CompleteSpawning.EnemySpawning spawncom;

    bool _spawning = false;

    // Use this for initialization
    void Start()
    {
        spawncom = GetComponent<CompleteSpawning.EnemySpawning>();
        Koreographer.Instance.RegisterForEvents("agu_loop_F_Spawn", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        n++;
        if (Audio_Agu_Loop_F.volume != 0f)
        {

            _spawning = true;

            if (_spawning)
                spawncom.Spawning();
        }




        if (Audio_Agu_Loop_F.volume == 0f)
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