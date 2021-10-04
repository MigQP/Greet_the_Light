using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnOnAudio : MonoBehaviour {

    public GameObject Enemigo_1;
    public float spawnThreshold = 0.5f;
    public int frequency = 0;
    public FFTWindow fftWindow;
    public float debugValue;

    public AudioSource theAudioSource;

    private float[] samples = new float[1024];


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        theAudioSource.GetSpectrumData(samples, 0, fftWindow);

      

        if (samples[frequency] > spawnThreshold)
        {
            //Instantiate(Enemigo_1, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
         Instantiate(Enemigo_1, transform.position, transform.rotation);
            debugValue = samples[frequency];
        }
     
    

     
    }
}
