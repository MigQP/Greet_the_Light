using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Tutorial_04 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        StartCoroutine(loadSceneAfterDelay(6));

    }

    IEnumerator loadSceneAfterDelay(float waitbySecs)
    {

        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene("loading_screen_01");
    }

    // Update is called once per frame
    void Update()
    {

    }
}