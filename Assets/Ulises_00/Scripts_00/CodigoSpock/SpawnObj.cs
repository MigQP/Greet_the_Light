using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    public GameObject ObjetoPrueba;


    void Update()
    {
        if (GameObject.FindWithTag ("Item") == null)
        {
            Instantiate(ObjetoPrueba, transform.position, transform.rotation);
            Destroy(gameObject);
        }
            


    }

}
