using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedEntry : MonoBehaviour {

	[SpaceAttribute(10)]
	[HeaderAttribute("Bools")]

	public bool animateOnStart = false;
	public bool offset = false;

	[SpaceAttribute(10)]
	[HeaderAttribute("Timing")]

	public float delay = 0;

	public float effecTime = 1;

	[SpaceAttribute(10)]
	[HeaderAttribute("Scale")]


	public Vector3 startScale;

	public AnimationCurve scaleCurve;

	[SpaceAttribute(10)]
	[HeaderAttribute("Position")]


	public Vector3 startPos;

	public AnimationCurve posCurve;

	Vector3 endScale;
	Vector3 endPos;


	// Use this for initialization
	void Start () {

		if (animateOnStart) 
		{
			SetUpVariables ();
			StartCoroutine (Animation());
		}

	}

	void Awake () {

		if (!animateOnStart) 
		{
			SetUpVariables ();

		}

	}

	void SetUpVariables () 
	{
		endScale = transform.localScale;
		endPos = transform.localPosition;
		if (offset) 
		{
			startPos += endPos;
		}
	}

	IEnumerator Animation()
	{
		transform.localPosition = startPos;
		transform.localScale = startScale;

		yield return new WaitForSecondsRealtime (delay);

		float time = 0;

		float perc = 0;

		float lastTime = Time.realtimeSinceStartup;

		do 
		{
			time += Time.realtimeSinceStartup - lastTime;
			lastTime = Time.realtimeSinceStartup;
			perc = Mathf.Clamp01(time / effecTime);
			Vector3 tempScale = Vector3.LerpUnclamped(startScale, endScale, scaleCurve.Evaluate(perc));
			Vector3 tempPos = Vector3.LerpUnclamped(startPos, endPos, posCurve.Evaluate(perc));
			transform.localScale = tempScale;
			transform.localPosition = tempPos;

			yield return null;

		} 
		while (perc < 1);

		transform.localScale = endScale;
		transform.localPosition = endPos;
		yield return null;
	}
}
