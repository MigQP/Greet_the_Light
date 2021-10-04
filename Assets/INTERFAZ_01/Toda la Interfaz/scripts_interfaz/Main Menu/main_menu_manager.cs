using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class main_menu_manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}



	public void ToShuffle ()
	{
        // ESCENA DONDE ESTA EL NIVEL

        //SONIDO DE ACEPTAR
       SceneManager.LoadScene(7);
    }

	public void ToLevelSelect ()
	{
		SceneManager.LoadScene (2);

        //SONIDO DE ACEPTAR
    }

    public void ToOptions ()
	{
		SceneManager.LoadScene (3);
        //SONIDO DE ACEPTAR
    }

    public void ExitGame () 
	{
        StartCoroutine("KillGame");
        
		Debug.Log ("HAS SALIDO DEL JUEGO");
        //SONIDO DE CASSETTE
    }

    public void ToControls()
	{
		SceneManager.LoadScene (4);

    }

    public void ToSettings()
	{
		SceneManager.LoadScene (5);
      
    }

    public void ToCredits()
	{
		SceneManager.LoadScene (6);
       
    }

    public IEnumerator KillGame ()
    {
        yield return new WaitForSeconds(1);
        Application.Quit();
    }


}
