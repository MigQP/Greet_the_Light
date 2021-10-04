using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SonicBloom.Koreo;

public class AnimOnKoreo : MonoBehaviour {

    bool _changeAnim = false;
    int _anim;
    CompleteAnimation.AnimOnTime spawnanim;

	// Use this for initialization
	void Start ()
    {
        spawnanim = GetComponent<CompleteAnimation.AnimOnTime>();
        Koreographer.Instance.RegisterForEvents("anim", OnMusicalShoot);
	}
	
    void OnMusicalShoot(KoreographyEvent evt)
    {
        if (evt.Payload is IntPayload)
        {
            _anim++;
         ;

            Debug.Log("CAE EL BEAT");
            if (_anim == 4)
            {
                _changeAnim = true;
                spawnanim._animation();
            }           
        }
    }

	// Update is called once per frame
	void Update () {
		
	}
}
