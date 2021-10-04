using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageParticulaTrail : MonoBehaviour
{
    public int damageToGive;

    void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.tag == "Enemigo")
        {
            other.gameObject.GetComponent<EnemyHealthManager>().HurtEnemy(damageToGive);
        }
    }
}
