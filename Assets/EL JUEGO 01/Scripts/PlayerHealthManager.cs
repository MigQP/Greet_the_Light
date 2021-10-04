using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthManager : MonoBehaviour {

  

    public int startingHealth;
	public int currentHealth;

	public float flashLength;
	private float flashCounter;

	private Renderer rend;
	private Color storedColor; 

	void Start () {
		currentHealth = startingHealth;
		rend = GetComponent<Renderer> ();
		storedColor = rend.material.GetColor ("_Color");

    }
	
	// Update is called once per frame
	void Update () {
		if (currentHealth <= 0) 
		{
			gameObject.SetActive (false);
           SceneManager.LoadScene(0);


            Scene currentScene = SceneManager.GetActiveScene ();
			string sceneName = currentScene.name;

				if (sceneName == "Prototipo_04") 
				{
					SceneManager.LoadScene (1);
				}
				
			Debug.Log ("ME MORI");
		}
		if (flashCounter > 0)
		{
			flashCounter -= Time.deltaTime;
			if (flashCounter <= 0) 
			{
				rend.material.SetColor ("_Color", storedColor);

			}
		}



	}

	public void HurtPlayer (int damageAmount)
	{
		currentHealth -= damageAmount;
		flashCounter = flashLength;
		rend.material.SetColor ("_Color", Color.white);
	}
}
