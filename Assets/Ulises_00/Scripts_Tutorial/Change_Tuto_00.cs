using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Tuto_00 : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {

        StartCoroutine(loadSceneAfterDelay(5));

    }

    IEnumerator loadSceneAfterDelay(float waitbySecs)
    {

        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene("tutorial_02");
    }

    // Update is called once per frame
    void Update () {
		
	}
}
