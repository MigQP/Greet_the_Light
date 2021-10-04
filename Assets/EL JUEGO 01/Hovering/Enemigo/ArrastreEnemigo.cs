using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrastreEnemigo : MonoBehaviour
{
    public float lifeTime;
    public float moveSpeed;
    public Rigidbody myrb;

    void Start()
    {
        myrb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        myrb.AddForce(transform.forward * moveSpeed);
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(gameObject);
            Debug.Log("REVISION DE RUTINA2222");
        }
    }
}