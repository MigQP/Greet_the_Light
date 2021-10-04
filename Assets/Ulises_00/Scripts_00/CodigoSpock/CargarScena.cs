using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CargarScena : MonoBehaviour {



    public void ShuffleScene()
    {
        SceneManager.LoadScene("loading_screen_01");
    }

    public void ExitGameClick()
    {
        Application.Quit();
    }

    public void TutorialScene()
    {
        SceneManager.LoadScene("tutorial_00");
    }


}
