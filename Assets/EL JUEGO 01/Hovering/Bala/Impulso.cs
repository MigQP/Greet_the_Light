using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impulso : MonoBehaviour
{
    public float thrust;
    public Rigidbody rb;

    void FixedUpdate ()
    {
        rb.transform.position += transform.forward * thrust;

    }
}