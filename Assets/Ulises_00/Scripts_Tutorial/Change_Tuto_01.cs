using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_Tuto_01 : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

        StartCoroutine(loadSceneAfterDelay(5));

    }

    IEnumerator loadSceneAfterDelay(float waitbySecs)
    {

        yield return new WaitForSeconds(waitbySecs);
        Application.LoadLevel("tutorial_02");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
