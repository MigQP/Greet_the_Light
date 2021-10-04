using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChargingScreen : MonoBehaviour {

    public GameObject loadingScreenObj;
    public Slider slider;

    AsyncOperation async;

	// Use this for initialization
	void Start () {
        LoadScreenExample();	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadScreenExample ()
    {
        StartCoroutine(LoadingScreen());
    }

    IEnumerator LoadingScreen()
    {
        loadingScreenObj.SetActive(true);
        async = SceneManager.LoadSceneAsync(6);
        async.allowSceneActivation = false;

        while (async.isDone == false)
        {
            slider.value = async.progress;
            if (async.progress == 0.9f)
            {
                slider.value = 1f;
                yield return new WaitForSeconds(3);
                async.allowSceneActivation = true;
            }
         
        }
    }
}
