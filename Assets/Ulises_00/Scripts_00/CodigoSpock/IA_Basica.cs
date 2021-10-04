using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA_Basica : MonoBehaviour
{

    public Transform playerShip;
    public int trust;

    void Start()
    {

    }

    void FixedUpdate()
    {
        transform.LookAt(playerShip.transform.position);
        Quaternion rotation = Quaternion.LookRotation(playerShip.transform.position - this.transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * trust);
        transform.Translate(Vector3.forward * trust * Time.deltaTime);
    }

}