using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrastre : MonoBehaviour
{
    public float lifeTime;
    public float thrust;
    public Rigidbody rb;
	int p = 0;

    public bool isActive;

    public GameObject particulaDisparo;


    public int damageToGive;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        

    }

    void Update()
    {
		rb.AddForce(transform.forward * thrust);
		lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {

            isActive = false;
            Destroy(gameObject);
           // Debug.Log("REVISION DE RUTINA");
			p++;
        }
			
		if (p == 10) 
		{
			
		}

    }
	void OnCollisionEnter (Collision other)
	{
		if (other.gameObject.tag == "Enemigo")
		{
            isActive = true;
            Instantiate(particulaDisparo, transform.position, Quaternion.identity);
            other.gameObject.GetComponent<EnemyHealthManager> ().HurtEnemy (damageToGive);
            Destroy(gameObject);
		}
        if (other.gameObject.tag == "CuerpoEnemigo")
        {
            Instantiate(particulaDisparo, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            isActive = true;
            Instantiate(particulaDisparo, transform.position, Quaternion.identity);
    
            Destroy(gameObject);
        }
        if (other.gameObject.tag == "CuerpoEnemigo")
        {
            Instantiate(particulaDisparo, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

    }
}
