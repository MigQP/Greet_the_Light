using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilVersion02 : MonoBehaviour
{
    public float lifeTime;
    public float thrust;
    public Rigidbody rb;

    void FixedUpdate()
    {
        rb.transform.position += transform.forward * thrust;
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
        }
    }
}