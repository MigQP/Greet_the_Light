using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {

	public int health;
	private int currentHealth;
    public GameObject particulaMuerte;
    public int valorScore = 0;
    public static bool isActive;
    public int chainScore = 1;
    public float chainTime = 2;
    public GameObject _theDestroyed;
    //ScoreManager scrmanager;

    void Start ()
    {

       
        currentHealth = health;
	}
	
	// Update is called once per frame
	void Update () {
        if (currentHealth <= 0)
        {
            ScoreManager.chainValue += chainScore;
            ScoreManager.chainDown += chainTime;
            ScoreManager.scoreValue += valorScore * ScoreManager.chainValue;
            isActive = true;
            Instantiate(particulaMuerte, transform.position, Quaternion.identity);
            Destroy(_theDestroyed);
        }

    }



    public void HurtEnemy(int damage)
	{
		currentHealth -= damage;
        isActive = true;
    }
}
