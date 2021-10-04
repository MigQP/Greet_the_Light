using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class ButtonCanvasManager : MonoBehaviour {

    //public int canvasNumber;

    public GameObject [] _CanvasClicks;
    public AudioSource _AudioSour;


    void Start ()
    {

       

        //Intro menu
        _CanvasClicks[0].SetActive(true);
        _CanvasClicks[1].SetActive(false);
        _CanvasClicks[2].SetActive(false);
        _CanvasClicks[3].SetActive(false);
        _CanvasClicks[4].SetActive(false);
        _CanvasClicks[5].SetActive(false);
        _CanvasClicks[6].SetActive(false);
        _CanvasClicks[7].SetActive(false);

        _AudioSour.volume = 0.0f;



    }

	
    public void Click1()
    {
        //Main menu
      
        _CanvasClicks[0].SetActive(false);
        _CanvasClicks[1].SetActive(true);
        _CanvasClicks[2].SetActive(false);
        _CanvasClicks[3].SetActive(false);
        _CanvasClicks[4].SetActive(false);
        _CanvasClicks[5].SetActive(false);
        _CanvasClicks[6].SetActive(false);
        _CanvasClicks[7].SetActive(false);

        _AudioSour.volume = 0.0f;

    }
    public void Click2()
    {
        //Options menu

        _CanvasClicks[0].SetActive(false);
        _CanvasClicks[1].SetActive(false);
        _CanvasClicks[2].SetActive(true);
        _CanvasClicks[3].SetActive(false);
        _CanvasClicks[4].SetActive(false);
        _CanvasClicks[5].SetActive(false);
        _CanvasClicks[6].SetActive(false);
        _CanvasClicks[7].SetActive(false);

        _AudioSour.volume = 0.0f;

    }
    public void Click3()
        //Control menu
    {
        _CanvasClicks[0].SetActive(false);
        _CanvasClicks[1].SetActive(false);
        _CanvasClicks[2].SetActive(false);
        _CanvasClicks[3].SetActive(true);
        _CanvasClicks[4].SetActive(false);
        _CanvasClicks[5].SetActive(false);
        _CanvasClicks[6].SetActive(false);
        _CanvasClicks[7].SetActive(false);

        _AudioSour.volume = 0.0f;

    }
    public void Click4()
    {
        //Credits menu
        _CanvasClicks[0].SetActive(false);
        _CanvasClicks[1].SetActive(false);
        _CanvasClicks[2].SetActive(false);
        _CanvasClicks[3].SetActive(false);
        _CanvasClicks[4].SetActive(true);
        _CanvasClicks[5].SetActive(false);
        _CanvasClicks[6].SetActive(false);
        _CanvasClicks[7].SetActive(false);

        _AudioSour.volume = 0.0f;
    }
    public void Click5()
    {
        //LevelSelect menu

        _CanvasClicks[0].SetActive(false);
        _CanvasClicks[1].SetActive(false);
        _CanvasClicks[2].SetActive(false);
        _CanvasClicks[3].SetActive(false);
        _CanvasClicks[4].SetActive(false);
        _CanvasClicks[5].SetActive(true);
        _CanvasClicks[6].SetActive(false);
        _CanvasClicks[7].SetActive(false);

        _AudioSour.volume = 1.0f;
    }
    public void Click6()
    {
        //scoreboard menu

        _CanvasClicks[0].SetActive(false);
        _CanvasClicks[1].SetActive(false);
        _CanvasClicks[2].SetActive(false);
        _CanvasClicks[3].SetActive(false);
        _CanvasClicks[4].SetActive(false);
        _CanvasClicks[5].SetActive(false);
        _CanvasClicks[6].SetActive(true);
        _CanvasClicks[7].SetActive(false);

        _AudioSour.volume = 0.0f;
    }
    public void Click7()
    {
        //Username menu

        _CanvasClicks[0].SetActive(false);
        _CanvasClicks[1].SetActive(false);
        _CanvasClicks[2].SetActive(false);
        _CanvasClicks[3].SetActive(false);
        _CanvasClicks[4].SetActive(false);
        _CanvasClicks[5].SetActive(false);
        _CanvasClicks[6].SetActive(false);
        _CanvasClicks[7].SetActive(true);

        _AudioSour.volume = 0.0f;
    }

}
