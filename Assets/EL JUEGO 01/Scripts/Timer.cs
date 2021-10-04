using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{

	public delegate void OnTimer (Timer sender);

	public event OnTimer On_TimerUpdate;
	public event OnTimer On_TimerComplete;

	public float seconds = 120;
	private bool isFinished = false;

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (Countdown ());
	}
		
	IEnumerator Countdown ()
	{
		while (!isFinished) {
			yield return new WaitForSeconds (1);
			seconds--;

			if(On_TimerUpdate != null){
				On_TimerUpdate(this);
			}	

			if (seconds < 1) {
				seconds = 0;
				isFinished = true;
		
				if(On_TimerComplete != null){
					On_TimerComplete(this);
				}
                StopCoroutine(Countdown());

				SceneManager.LoadScene(0);
            }
		}
	}
}
