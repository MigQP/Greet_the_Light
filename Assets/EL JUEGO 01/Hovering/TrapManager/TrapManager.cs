using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapManager : MonoBehaviour {

    public HovShoot theShoot;
    public Dash3D theDash;
    public Aplastar theAplaste;
    public float theSperas;

    bool cooldown;
    private int n = 0;

    void Start()
    {
        theShoot = GetComponent<HovShoot>();
        theDash = GetComponent<Dash3D>();
        theAplaste = GetComponent<Aplastar>();
        cooldown = false;
    }


    IEnumerator TrapTimer()
    {
        cooldown = true;
        yield return new WaitForSeconds(theSperas);
        n++;

        if (n == 4)
        {
            n = 1;
        }

        if (n == 1)
        {
            theShoot.enabled = false;
            theDash.enabled = true;
            theAplaste.enabled = false;
        }

        if (n == 2)
        {
            theShoot.enabled = false;
            theDash.enabled = false;
            theAplaste.enabled = true;
        }

        if (n == 3)
        {
            theShoot.enabled = true;
            theDash.enabled = false;
            theAplaste.enabled = false;
        }

        cooldown = false;
    }


	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!cooldown)
            {
                StartCoroutine(TrapTimer());
            }
        }
	}
}
