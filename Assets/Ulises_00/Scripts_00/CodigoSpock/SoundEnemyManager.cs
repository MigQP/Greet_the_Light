using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEnemyManager : MonoBehaviour {

   
    public AudioClip theClip;
    public AudioSource audioSource;
    public GameObject theSpawner;
    public SpawnEnemies spawnEnemies;

    bool activado = true;


    // Use this for initialization
    void Start()
    {
        audioSource = GameObject.Find("AudioPeer").GetComponent<AudioSource>();
        theSpawner = GameObject.Find("SpawnEnemies_003");
        
    }
	
	// Update is called once per frame
	void Update ()
    {
		if (!audioSource.isPlaying)
        {
            theSpawner.SetActive(false);
                  
        }
	}
}
