using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change_Tuto_03 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        StartCoroutine(loadSceneAfterDelay(10));

    }

    IEnumerator loadSceneAfterDelay(float waitbySecs)
    {

        yield return new WaitForSeconds(waitbySecs);
        SceneManager.LoadScene("tutorial_04");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
