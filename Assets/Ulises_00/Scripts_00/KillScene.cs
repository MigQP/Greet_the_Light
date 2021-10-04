using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillScene : MonoBehaviour {

               // How long between each spawn.
        // An array of the spawn points this enemy can spawn from.
    bool isSounding = true;
    bool isCreating = true;
    public AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("AudioPeer").GetComponent<AudioSource>();

    }

    void Update()
    {

        if (!audioSource.isPlaying)
        {

            Application.LoadLevel("title_screen");
        }
    }
}
