using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPause : MonoBehaviour

{
    public AudioSource audioSource;
    public bool GameIsPaused = false;
    public GameObject pauseMenuUI;





    public CanvasGroup _selection;




    int n;

    // Use this for initialization
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("activo Escape");
           
            n++;

            if (n == 1)
            {
                Pause();
            }
            if (n == 2)
            {
                n = 0;
                Resume();
            }



        }
    }

    public void Resume()
    {
        n = 0;
        Time.timeScale = 1f;
        pauseMenuUI.SetActive(false);
        audioSource.Play(0);
      
        
        GameIsPaused = false;

    }

    void Pause()
    {
        Time.timeScale = 0f;
        pauseMenuUI.SetActive(true);
        audioSource.Pause();

     //   Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void loadMenu()
    {
        SceneManager.LoadScene("titlescreen_01");
    }







}