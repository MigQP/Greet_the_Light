﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phillotaxis_Global : MonoBehaviour

{
    public AudioPeer_Global _audioPeer;
    private Material _trailMat;
    public Color _trailColor;

    public float _degree, _scale;
    public int _numberStart;
    public int _stepSize;
    public int _maxIteration;

    //Es el Lerping güe
    public bool _useLerping;
    //public float _intervalLerp;
    private bool _isLerping;
    private Vector3 _startPosition, _endPosition;
    //private float _timeStartedLerping;

    private float _lerpPosTimer, _lerpPosSpeed;
    public Vector2 _lerpPosSpeedMinMax;
    public AnimationCurve _lerpPosAnimCurve;
    public int _lerpPosBand;

    private int _number;
    private int _currentIteration;

    private TrailRenderer _trailRenderer;


    void Start()
    {

    }

    private Vector2 CalculatePhyllotaxis(float degree, float scale, int number)
    {
        double angle = number * (degree * Mathf.Deg2Rad);
        float r = scale * Mathf.Sqrt(number);
        float x = r * (float)System.Math.Cos(angle);
        float y = r * (float)System.Math.Sin(angle);
        Vector2 vec2 = new Vector2(x, y);
        return vec2;

    }

    private Vector2 _phyllotaxisPosition;

    private bool _forward;
    public bool _repeat, _invert;


    //scaling
    public bool _useScaleAnimation, _useScaleCurve;
    public Vector2 _ScaleAnimMinMax;
    public AnimationCurve _scaleAnimCurve;
    public float _scaleAnimSpeed;
    public int _scaleBand;
    private float _scaleTimer, _currentScale;


    void SetLerpPostions()
    {
        //esto es para el 2D
        //_isLerping = true;
        //_timeStartedLerping = Time.time;
        _phyllotaxisPosition = CalculatePhyllotaxis(_degree, _currentScale, _number);
        _startPosition = this.transform.localPosition;
        _endPosition = new Vector3(_phyllotaxisPosition.x, _phyllotaxisPosition.y, 0);
    }

    //El stratLerping es para los Phyllotaxis 2D we
    void Awake()
    {
        _currentScale = _scale;
        _forward = true;
        _trailRenderer = GetComponent<TrailRenderer>();
        _trailMat = new Material(_trailRenderer.material);
        _trailMat.SetColor("_TintColor", _trailColor);
        _trailRenderer.material = _trailMat;
        _number = _numberStart;
        transform.localPosition = CalculatePhyllotaxis(_degree, _currentScale, _number);
        if (_useLerping)
        {
            _isLerping = true;
            //StartLerping();
            SetLerpPostions();
        }

    }

    private void Update()
    {
        if (_useScaleAnimation)
        {
            if (_useScaleCurve)
            {
                _scaleTimer += (_scaleAnimSpeed * _audioPeer._audioBand[_scaleBand]) * Time.deltaTime;
                if (_scaleTimer >= 1)
                {
                    _scaleTimer -= 1;
                }
                _currentScale = Mathf.Lerp(_ScaleAnimMinMax.x, _ScaleAnimMinMax.y, _scaleAnimCurve.Evaluate(_scaleTimer));
            }
            else
            {
                _currentScale = Mathf.Lerp(_ScaleAnimMinMax.x, _ScaleAnimMinMax.y, _audioPeer._audioBand[_scaleBand]);
            }
        }



        if (_useLerping)
        {
            if (_isLerping)
            {
                _lerpPosSpeed = Mathf.Lerp(_lerpPosSpeedMinMax.x, _lerpPosSpeedMinMax.y, _lerpPosAnimCurve.Evaluate(_audioPeer._audioBand[_lerpPosBand]));
                _lerpPosTimer += Time.deltaTime * _lerpPosSpeed;
                transform.localPosition = Vector3.Lerp(_startPosition, _endPosition, Mathf.Clamp01(_lerpPosTimer));
                if (_lerpPosTimer >= 1)
                {
                    _lerpPosTimer -= 1;
                    if (_forward)
                    {
                        _number += _stepSize;
                        _currentIteration++;
                    }
                    else
                    {
                        _number -= _stepSize;
                        _currentIteration--;
                    }
                    if ((_currentIteration > 0) && (_currentIteration < _maxIteration))
                    {
                        SetLerpPostions();
                    }
                    else //
                    {
                        if (_repeat)
                        {
                            if (_invert)
                            {
                                _forward = !_forward;
                                SetLerpPostions();
                            }
                            else
                            {
                                _number = _numberStart;
                                _currentIteration = 0;
                                SetLerpPostions();
                            }
                        }
                        else
                        {
                            _isLerping = false;
                        }
                    }
                }
            }
        }
        if (!_useLerping)
        {
            _phyllotaxisPosition = CalculatePhyllotaxis(_degree, _currentScale, _number);
            transform.localPosition = new Vector3(_phyllotaxisPosition.x, _phyllotaxisPosition.y, 0);
            _number += _stepSize;
            _currentIteration++;
        }
    }

}
