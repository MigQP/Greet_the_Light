using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class title_manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.anyKey)
		{
            SceneManager.LoadScene(8);
            //SONIDO DE ACEPTAR 

            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
		}
		if (Input.GetKey (KeyCode.JoystickButton0))
		{
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }
        if (Input.GetKey(KeyCode.JoystickButton1))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton2))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton3))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton4))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton5))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton6))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton7))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton8))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey(KeyCode.JoystickButton9))
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetKey (KeyCode.JoystickButton10))
		{
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }
		if (Input.GetKey (KeyCode.JoystickButton11))
		{
			SceneManager.LoadScene (8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");


        }

        

        if (Input.GetAxisRaw("Vertical") > 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("Vertical") < 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("DPadX") > 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("DPadX") < 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("DPadY") > 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("DPadY") < 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("LeftTrigger") > 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("LeftTrigger") < 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("RightTrigger") > 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }

        if (Input.GetAxisRaw("RightTrigger") < 0)
        {
            SceneManager.LoadScene(8);
            FMODUnity.RuntimeManager.PlayOneShot("event:/Click");
        }






    }
}
