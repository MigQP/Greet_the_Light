using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurnOnSelection : MonoBehaviour {
	public CanvasGroup _selection;


	public void FadeIn()
	{
		StartCoroutine (FadeCanvasGroup (_selection, _selection.alpha, 1));
	}

	public void FadeOut()
	{
		StartCoroutine (FadeCanvasGroup (_selection, _selection.alpha, 0));
	}

	public IEnumerator FadeCanvasGroup(CanvasGroup cg, float start, float end, float lerpTime = .25f)
	{

		float _timeStartedLerping = Time.time;
		float timeSinceStarted = Time.time - _timeStartedLerping;
		float percentageComplete = timeSinceStarted / lerpTime;


		while (true) {
			timeSinceStarted = Time.time - _timeStartedLerping;
			percentageComplete = timeSinceStarted / lerpTime;

			float currentValue = Mathf.Lerp (start, end, percentageComplete);

			cg.alpha = currentValue;

			if (percentageComplete >= 1)	break;

			yield return new WaitForEndOfFrame ();
		}

	
	}


}
