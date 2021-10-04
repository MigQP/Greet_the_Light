using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TransBar1 : MonoBehaviour {

    Image transBar1;
    public float maxTrans1 = 10;
    public static float trans1;

    // Use this for initialization
    void Start()
    {
        transBar1 = GetComponent<Image>();
        trans1 = maxTrans1;
    }

    // Update is called once per frame
    void Update()
    {
        transBar1.fillAmount = trans1 / maxTrans1;
    }
}
