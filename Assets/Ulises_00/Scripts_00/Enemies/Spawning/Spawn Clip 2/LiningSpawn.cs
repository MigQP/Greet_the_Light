using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class LiningSpawn : MonoBehaviour {



    int n = 0;

    public bool _changeSpawning = false;

    CompleteSpawning.EnemySpawning spawncom;

  


    // Use this for initialization
    void Start () {
        Koreographer.Instance.RegisterForEvents("linespawn", OnBeatDrop);
    }


    void OnBeatDrop(KoreographyEvent evt)
    {
        if (evt.Payload is IntPayload)
        {
            spawncom.SpawningThree();
            
        }
    }

        // Update is called once per frame
        void Update () {
		
	}
}
