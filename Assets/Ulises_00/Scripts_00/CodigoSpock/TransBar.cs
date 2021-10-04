using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransBar : MonoBehaviour {

    Image transBar;
    public float maxTrans = 5;
    public static float trans;

	// Use this for initialization
	void Start ()
    {
        transBar = GetComponent<Image>();
        trans = maxTrans;
	}
	
	// Update is called once per frame
	void Update () {
        transBar.fillAmount = trans / maxTrans;
	}
}
