using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    public Text valorScore;
    public Text chainNumber;

    public static float scoreValue = 0.0f;
    public static float scoreProduct = 0.0f;
    public static float chainValue = 0.0f;
    public int scoreCount; // What the score is when the scene first loads. I set this as zero.

    public int scoreMultiplier = 0;

    public static float chainDown = 0;
    public float chainDownTimer;

    bool _activateChain = false;

    void Start()

    {
        chainNumber = GetComponent<Text>();     
    }

    // Update is called once per frame
    void Update()
    {
        chainNumber.text = "Score:" + Mathf.Round(scoreValue) + "\n" + "Chain:" + Mathf.Round(chainValue);

        if (scoreValue * chainValue > 0)
        {
            //scoreProduct = scoreValue * chainValue;
        }

        if (scoreValue * chainValue <= 0)
        {
            //	scoreProduct = scoreProduct;
        }

        if (chainValue != 0)
        {

            _activateChain = true;

            if (_activateChain)
            {
                if (chainDownTimer > 0)
                {
                    chainDownTimer -= Time.deltaTime;
                }

                if (chainDownTimer == 0)
                {
                    chainDownTimer = chainDown;

                }
                if (chainDownTimer < 0)
                {
                    chainValue = 0;
                    chainDownTimer = 0;

                    _activateChain = false;
                }
            }

        }

    }

}