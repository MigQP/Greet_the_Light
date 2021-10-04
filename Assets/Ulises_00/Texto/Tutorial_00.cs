using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial_00 : MonoBehaviour
{

    public GameObject panel;
    public string textShip;

    void Awake()
    {

        if (panel == null)
        {
            Debug.LogWarning("Se te olvido poner Panel");
        }
        else
        {
            panel.SetActive(false);
            panel.GetComponentInChildren<Text>().text = textShip;
        }
    }
    void Start()
    {
      
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            panel.SetActive(true);
        }
    }


    void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            panel.SetActive(false);
        }
    }

}