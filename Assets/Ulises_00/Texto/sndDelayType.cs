using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sndDelayType : MonoBehaviour {
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
			yield return new WaitForSeconds (6.0f);
		}

		for (i = 0; i < fulltext.Length; i++) 
		{

			currentText = fulltext.Substring (0, i);
			this.GetComponent<Text> ().text = currentText;	
			yield return new WaitForSeconds (delay);

		}
	}
}
