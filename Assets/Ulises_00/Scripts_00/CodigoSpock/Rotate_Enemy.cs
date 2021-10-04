using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate_Enemy : MonoBehaviour
{
    //public int trust;
    public Transform playerShip;
    public GameObject ThePlayer;

    // Use this for initialization
    void Start()
    {
        ThePlayer = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {

        transform.LookAt(playerShip.transform.position);
        Quaternion rotation = Quaternion.LookRotation(playerShip.transform.position - this.transform.position);
        //transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * trust);
        //transform.Translate(Vector3.forward * trust * Time.deltaTime);
    }
}