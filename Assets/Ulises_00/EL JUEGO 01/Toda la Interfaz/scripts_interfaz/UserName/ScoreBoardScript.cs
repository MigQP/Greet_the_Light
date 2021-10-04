using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoardScript : MonoBehaviour
{

    public Text scoreText1;
    public Text scoreText2;
    public Text scoreText3;
    public Text name1;
    public Text name2;
    public Text name3;

	// Use this for initialization
	void Start ()
    {
	    	
        if (PlayerPrefs.GetFloat("score") > PlayerPrefs.GetFloat("1st"))
        {
            PlayerPrefs.SetFloat("3rd", PlayerPrefs.GetFloat("2nd"));
            PlayerPrefs.SetFloat("2nd", PlayerPrefs.GetFloat("1st"));
            PlayerPrefs.SetFloat("1st", PlayerPrefs.GetFloat("score"));

            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("name1"));
            PlayerPrefs.SetString("name1", PlayerPrefs.GetString("username"));
        }

        if (PlayerPrefs .GetFloat("score") < PlayerPrefs .GetFloat("1st") && PlayerPrefs .GetFloat("score") > PlayerPrefs .GetFloat("2nd"))
        {
            PlayerPrefs.SetFloat("3rd", PlayerPrefs.GetFloat("2nd"));
            PlayerPrefs.SetFloat("2nd", PlayerPrefs.GetFloat("score"));

            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("name2"));
            PlayerPrefs.SetString("name2", PlayerPrefs.GetString("username"));
        }

        if (PlayerPrefs.GetFloat("score") < PlayerPrefs.GetFloat("2nd") && PlayerPrefs.GetFloat("score") > PlayerPrefs.GetFloat("3rd"))
        {
            PlayerPrefs.SetFloat("3rd", PlayerPrefs.GetFloat("score"));
            PlayerPrefs.SetString("name3", PlayerPrefs.GetString("username"));
        }

        scoreText1.text = PlayerPrefs.GetFloat("1st").ToString();
        scoreText2.text = PlayerPrefs.GetFloat("2nd").ToString();
        scoreText3.text = PlayerPrefs.GetFloat("3rd").ToString();
        name1.text = PlayerPrefs.GetString("name1");
        name2.text = PlayerPrefs.GetString("name2");
        name3.text = PlayerPrefs.GetString("name3");

	}

}
