using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;
using UnityEngine.SceneManagement;

public class ProceduralManager : MonoBehaviour

{
    public int _timesToChange;
    public int _clipsPassed = 0;
    public Multisonido[] Agudos;
    public Multisonido[] Bajos;
    public Multisonido[] Base;
    public Multisonido[] Medios;

    int _songCounter;
    
    int _tamañoAgudos;

    int _tamañoBajos;

    int _tamañoBase;

    int _tamañoMedios;


    void Start()
    {
         InvokeRepeating("ChooseLoop", 0f, 7.0f);
          InvokeRepeating("FadeLoop", 0f, 6.8f);
        _songCounter = 17;

    
        Koreographer.Instance.RegisterForEvents("loopentrance", OnMusicalShoot);
      

        StartCoroutine(ExitLevel());
    
    }





    void ChooseLoop()

    {
        int i = Random.Range(0, 100);

        // Procedural AGUDOS  

        for (_tamañoAgudos = 0; _tamañoAgudos < Agudos.Length; _tamañoAgudos++)
        {
            if (i >= Agudos[_tamañoAgudos].minProbababiltyRange && i <= Agudos[_tamañoAgudos].maxProbabilityRange)
            {
                //  Agudos[_tamañoAgudos]._correspondingLoop.volume = 1f;

                StartCoroutine("FadeInAgudos");
                break;
            }
        }

        // Procedural BAJOS

        for (_tamañoBajos = 0; _tamañoBajos < Bajos.Length; _tamañoBajos++)
        {
            if (i >= Bajos[_tamañoBajos].minProbababiltyRange && i <= Bajos[_tamañoBajos].maxProbabilityRange)
            {
             //   Bajos[_tamañoBajos]._correspondingLoop.volume = 1f;

                StartCoroutine("FadeInBajos");
                break;
            }
        }

        // Procedural BASE

        for (_tamañoBase = 0; _tamañoBase < Base.Length; _tamañoBase++)
        {
            if (i >= Base[_tamañoBase].minProbababiltyRange && i <= Base[_tamañoBase].maxProbabilityRange)
            {
              //  Base[_tamañoBase]._correspondingLoop.volume = 1f;
                StartCoroutine("FadeInBase");
                break;
            }
        }

        //Procedural MEDIOS 

        for (_tamañoMedios = 0; _tamañoMedios < Medios.Length; _tamañoMedios++)
        {
            if (i >= Medios[_tamañoMedios].minProbababiltyRange && i <= Medios[_tamañoMedios].maxProbabilityRange)
            {
               // Medios[_tamañoMedios]._correspondingLoop.volume = 1f;
                StartCoroutine("FadeInMedios");
                break;
            }
        }

         
    }

    // Update is called once per frame
    void OnMusicalShoot(KoreographyEvent evt)
    {
        _clipsPassed++;

        Debug.Log("LOOP HAS PASSED");


        if (_clipsPassed == _timesToChange)
        {
            // _loopGroup[1]._correspondingLoop.volume = 1f;

            if (Agudos[1]._correspondingLoop.volume == 1f)
            {

            }
        //    StartCoroutine(FadeIn());
        }

    }

    void Update()
    {
        
        // ChooseLoop();
        CheckCounter();
        
    }

 public IEnumerator FadeInAgudos ()
    {
        while (Agudos[_tamañoAgudos]._correspondingLoop.volume < 1f)
        {
            Agudos[_tamañoAgudos]._correspondingLoop.volume += Time.deltaTime * .2f;
            yield return null;
        }

        Agudos[_tamañoAgudos]._correspondingLoop.volume = 1;
    }

    public IEnumerator FadeInBajos()
    {
        while (Bajos[_tamañoBajos]._correspondingLoop.volume < 1f)
        {
            Bajos[_tamañoBajos]._correspondingLoop.volume += Time.deltaTime * .2f;
            yield return null;
        }

        Bajos[_tamañoAgudos]._correspondingLoop.volume = 1;
    }

    public IEnumerator FadeInBase()
    {
        while (Base[_tamañoBase]._correspondingLoop.volume < 1f)
        {
            Base[_tamañoBase]._correspondingLoop.volume += Time.deltaTime * .2f;
            yield return null;
        }

        Base[_tamañoAgudos]._correspondingLoop.volume = 1;
    }

    public IEnumerator FadeInMedios()
    {
        while (Medios[_tamañoMedios]._correspondingLoop.volume < 1f)
        {
            Medios[_tamañoAgudos]._correspondingLoop.volume += Time.deltaTime * .2f;
            yield return null;
        }

        Medios[_tamañoMedios]._correspondingLoop.volume = 1;
    }

    public IEnumerator FadeOutAgudos()
    {


        while (Agudos[_tamañoAgudos]._correspondingLoop.volume > 0.01f)
        {
            Agudos[_tamañoAgudos]._correspondingLoop.volume -= Time.deltaTime / 2.0f;
            yield return null;
        }

       Agudos[_tamañoAgudos]._correspondingLoop.volume = 0;
    }

    public IEnumerator FadeOutBajos()
    {


        while (Bajos[_tamañoBajos]._correspondingLoop.volume > 0.01f)
        {
            Bajos[_tamañoBajos]._correspondingLoop.volume -= Time.deltaTime / 2.0f;
            yield return null;
        }

        Bajos[_tamañoBajos]._correspondingLoop.volume = 0;
    }

    public IEnumerator FadeOutBase()
    {


        while (Base[_tamañoBase]._correspondingLoop.volume > 0.01f)
        {
            Base[_tamañoBase]._correspondingLoop.volume -= Time.deltaTime / 2.0f;
            yield return null;
        }

        Base[_tamañoBase]._correspondingLoop.volume = 0;
    }

    public IEnumerator FadeOutMedios()
    {


        while (Medios[_tamañoMedios]._correspondingLoop.volume > 0.01f)
        {
            Medios[_tamañoMedios]._correspondingLoop.volume -= Time.deltaTime / 2.0f;
            yield return null;
        }

        Medios[_tamañoMedios]._correspondingLoop.volume = 0;
    }


    public void FadeLoop ()
    {
      

        StartCoroutine("FadeOutAll");
    }



public IEnumerator FadeOutAll ()
    {
        yield return new WaitForSeconds(0);
        StartCoroutine("FadeOutAgudos");
        StartCoroutine("FadeOutBajos");
        StartCoroutine("FadeOutBase");
        StartCoroutine("FadeOutMedios");
    }

    public void CheckCounter()
    {
        if (--_songCounter == 0)
        {
            CancelInvoke("ChooseLoop");
            CancelInvoke("FadeLoop");

           
            }
    }

    IEnumerator ExitLevel()
    {
        yield return new WaitForSeconds(122);
        SceneManager.LoadScene(0);
    }

    [System.Serializable]
    public class Multisonido
    {
        public AudioSource _correspondingLoop;
        public int minProbababiltyRange = 0;
        public int maxProbabilityRange = 0;
    }

}