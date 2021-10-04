using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitleShot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void TitleSc ()
    {

        StartCoroutine("LoadTitle");
        Time.timeScale = 1f;
    }

   public  IEnumerator LoadTitle ()
    {
        yield return new WaitForSeconds(.5f);
      //  Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
