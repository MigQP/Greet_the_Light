using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmissiveOnAmp : MonoBehaviour {

    public bool _useBuffer;
    Material _material;
    public float _red, _green, _blue;

    // Use this for initialization
    void Start()
    {
        _material = GetComponent<MeshRenderer>().materials[0];
    }

    // Update is called once per frame
    void Update()
    {

        if (!_useBuffer)
        {
            
            Color _color = new Color(_red * AudioPeer._Amplitude, _green * AudioPeer._Amplitude, _blue * AudioPeer._Amplitude);
            _material.SetColor("_Color", _color);
        }
        if (_useBuffer)
        {
            
            Color _color = new Color(_red * AudioPeer._AmplitudeBuffer, _green * AudioPeer._AmplitudeBuffer, _blue * AudioPeer._AmplitudeBuffer);
            _material.SetColor("_Color", _color);
        }
    }
}
