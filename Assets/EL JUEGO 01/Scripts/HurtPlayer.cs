using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayer : MonoBehaviour {

	public int damageToGive;

	public void OnTriggerStay (Collider other)
	{
		if (other.gameObject.tag == "Player") 
		{
			other.gameObject.GetComponent<PlayerHealthManager> ().HurtPlayer (damageToGive);
            HealtBar.health -= damageToGive;
		}
	}

}
