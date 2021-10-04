using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelayType : MonoBehaviour {
	public float delay = 0.1f;
	public string fulltext;
	string currentText = "";
	int i = 0;

	// Use this for initialization
	void Start () {
		StartCoroutine (ShowText ());	
	}

	IEnumerator ShowText() {
		if (i == 0) 
		{
			yield return new WaitForSeconds (2.5f);
		}

		for (i = 0; i < fulltext.Length; i++) 
		{
			
			currentText = fulltext.Substring (0, i);
			this.GetComponent<Text> ().text = currentText;	
			yield return new WaitForSeconds (delay);

		}
	}
}
