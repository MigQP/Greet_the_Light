using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour

{
    public PlayerHealthManager playerHealth;       // Reference to the player's heatlh.
    public GameObject Enemigo_1;                // The enemy prefab to be spawned.
    public float spawnTime = 3f;            // How long between each spawn.
    public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
    bool isSounding = true;
    bool isCreating = true;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("AudioPeer").GetComponent<AudioSource>();
      
    }

    void Update()
    {    

       if (isCreating)
        {
            InvokeRepeating("Spawn", spawnTime, spawnTime);
            isCreating = false;
        }
    }


    void Spawn()
    {
        if (playerHealth.currentHealth <= 0f)
        {
            // ... exit the function.
            return;
        }

        int spawnPointIndex = Random.Range(0, spawnPoints.Length);
 
        if (isSounding == true)
        {
            Instantiate(Enemigo_1, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
           
        }

        if (!audioSource.isPlaying)
        {
            isSounding = false;


        }
    }
}

