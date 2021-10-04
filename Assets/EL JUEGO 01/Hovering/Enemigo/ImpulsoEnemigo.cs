using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpulsoEnemigo : MonoBehaviour
{
    public float EnemyThrust;
    public float smoothspeed = 1f; 
    private Transform lookAt;
    public Transform Ship;
    public GameObject TheShip;
    public GameObject ThePlayer;

    public float _timeToDestroy;

    void Start()
    {       
         InvokeRepeating("DestroyByTime", 0.0f, _timeToDestroy);
        ThePlayer = GameObject.FindWithTag("Player");
    }

    void Update()
    {  
            TheShip = GameObject.Find("Ship");
            Ship.position = TheShip.transform.position;
            lookAt = Ship;

        Vector3 desiredPosition = lookAt.transform.position;
        {
            //transform.rotation = Quaternion.Slerp(transform.rotation, desiredPosition , Time.deltaTime * EnemyThrust);
            transform.Translate(Vector3.forward * EnemyThrust * Time.deltaTime);
            transform.position = Vector3.Lerp(transform.position, desiredPosition, smoothspeed);
            //EnemyRb.transform.position += transform.forward * EnemyThrust;
        }        
        
    }

    void DestroyByTime()
    {
       // Destroy(gameObject);
    }

}