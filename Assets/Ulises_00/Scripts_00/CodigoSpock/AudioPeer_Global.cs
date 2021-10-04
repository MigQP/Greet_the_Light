using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class AudioPeer_Global : MonoBehaviour
{
    AudioSource _audioSource;

    private int _useVato = 1;

    public int _MicNumber = 0;

    //AudioSources
    public AudioClip _audioClip;
    public bool _useMicrophone;
    public string _selectedDevice;
    public AudioMixerGroup _mixerGroupMicrophone, _mixerGroupMaster;

    //Main
    private float[] _samplesLeft = new float[512];
    private float[] _samplesRight = new float[512];
    private float[] _samples = new float[512];


    //audio sin 64 buffer
    private float[] _freqBand = new float[8];
    private float[] _bandBuffer = new float[8];
    private float[] _bufferDecrease = new float[8];
    public float[] _freqBandHighest = new float[8];

    //audio64 buffer
    private float[] _freqBand64 = new float[64];
    private float[] _bandBuffer64 = new float[64];
    private float[] _bufferDecrease64 = new float[64];
    public float[] _freqBandHighest64 = new float[64];

    [HideInInspector]
    public float[] _audioBand, _audioBandBuffer;
    [HideInInspector]
    public float[] _audioBand64, _audioBandBuffer64;
    [HideInInspector]
    public float _Amplitude, _AmplitudeBuffer;


    private float _AmplitudeHighest;
    public float _audioProfile;

    public enum _channel { stereo, Left, Right };
    public _channel channel = new _channel();



    void Start()
    {
        _audioBand = new float[8];
        _audioBandBuffer = new float[8];

        _audioBand = new float[64];
        _audioBandBuffer = new float[64];

        _audioSource = GetComponent<AudioSource>();
        AudioProfile(_audioProfile);

        //entrada del mic
         if (_useMicrophone)
        {
            if (Microphone.devices.Length > 0)
            {
                _selectedDevice = Microphone.devices[_MicNumber].ToString();
                _audioSource.outputAudioMixerGroup = _mixerGroupMicrophone;
                _audioSource.clip = Microphone.Start(_selectedDevice, true, 1, AudioSettings.outputSampleRate);
            }
            else
            {
                _useMicrophone = false;
            }
        }
        if (!_useMicrophone)
        {
            _audioSource.outputAudioMixerGroup = _mixerGroupMaster;
            _audioSource.clip = _audioClip;
        }

        _audioSource.Play();
    }

    void Update()
    {
        GetSpectrumAudioSource();
        MakeFrequencyBands();
        //MakeFrequencyBands64();
        BandBuffer();
        //BandBuffer64();
        CreateAudioBands();
        //CreateAudioBands64();
        GetAmplitude();
    }

    void AudioProfile(float audioProfile)
    {
        for (int i = 0; i < 8; i++)
        {
            _freqBandHighest[i] = audioProfile;
        }
    }

    void GetAmplitude()
    {
        float _CurrentAmplitude = 0;
        float _CurrentAmplitudeBuffer = 0;
        for (int i = 0; i < 8; i++)
        {
            _CurrentAmplitude += _audioBand[i];
            _CurrentAmplitudeBuffer += _audioBandBuffer[i];
        }
        if (_CurrentAmplitude > _AmplitudeHighest)
        {
            _AmplitudeHighest = _CurrentAmplitude;
        }

        _Amplitude = _CurrentAmplitude / _AmplitudeHighest;
        _AmplitudeBuffer = _CurrentAmplitudeBuffer / _AmplitudeHighest;

    }

    void CreateAudioBands()
    {
        for (int i = 0; i < 8; i++)
        {
            if (_freqBand[i] > _freqBandHighest[i])
            {
                _freqBandHighest[i] = _freqBand[i];
            }

            _audioBand[i] = (_freqBand[i] / _freqBandHighest[i]);
            _audioBandBuffer[i] = (_bandBuffer[i] / _freqBandHighest[i]);

        }
    }
    //Este show no funciona con las bandas del Phillotaxis
    /*void CreateAudioBands64()
    {
        for (int i = 0; i < 64; i++)
        {
            if (_freqBand64[i] > _freqBandHighest64[i])
            {
                _freqBandHighest64[i] = _freqBand64[i];
            }

            _audioBand64[i] = (_freqBand64[i] / _freqBandHighest64[i]);
            _audioBandBuffer64[i] = (_bandBuffer64[i] / _freqBandHighest64[i]);

        }
    }*/

    void GetSpectrumAudioSource()
    {
        //canal izquierdo y derecho (0,1)
        _audioSource.GetSpectrumData(_samplesLeft, 0, FFTWindow.Blackman);
        _audioSource.GetSpectrumData(_samplesRight, 1, FFTWindow.Blackman);
    }

    void BandBuffer()
    {
        for (int g = 0; g < 8; ++g)
        {
            if (_freqBand[g] > _bandBuffer[g])
            {
                _bandBuffer[g] = _freqBand[g];
                _bufferDecrease[g] = 0.005f;

            }

            if (_freqBand[g] < _bandBuffer[g])
            {
                _bandBuffer[g] -= _bufferDecrease[g];
                _bufferDecrease[g] *= 1.2f;

            }

        }
    }

    void BandBuffer64()
    {
        for (int g = 0; g < 64; ++g)
        {
            if (_freqBand64[g] > _bandBuffer64[g])
            {
                _bandBuffer64[g] = _freqBand64[g];
                _bufferDecrease64[g] = 0.005f;

            }

            if (_freqBand64[g] < _bandBuffer64[g])
            {
                _bandBuffer64[g] -= _bufferDecrease64[g];
                _bufferDecrease64[g] *= 1.2f;

            }

        }
    }

    void MakeFrequencyBands()
    {
        /*
         *  22050 / 256 = 86.1 hertz per sample
         *  
         *  0 - 2 = 172.2 hertz
         *  1 - 4 = 344.4 hertz - 172.6 - 516.6 
         *  2 - 8 = 688.8 hertz - 517 - 1033.2
         *  3 - 16 = 1377.6 hertz - 689 - 2066.4
         *  4 - 32 = 2755.2 hertz - 2067 - 4132.8
         *  5 - 64 = 5510.4 hertz - 4133 - 8265.6
         *  6 - 128 = 11020.8 hertz - 8266 - 16531.2
         *  7 - 256 = 22041.6 hertz - 16532 - 33062.4
         *  510
         *  
         */

        int count = 0;

        for (int i = 0; i < 8; i++)
        {
            float average = 0;
            int sampleCount = (int)Mathf.Pow(2, i) * 2;

            if (i == 7)
            {
                sampleCount += 2;
            }
            for (int j = 0; j < sampleCount; j++)
            {
                if (channel == _channel.stereo)
                {
                    average += _samplesLeft[count] + _samplesRight[count] * (count + 1);
                }
                if (channel == _channel.Left)
                {
                    average += _samplesLeft[count] * (count + 1);
                }
                if (channel == _channel.Right)
                {
                    average += _samplesRight[count] * (count + 1);
                }

                count++;
            }

            average /= count;
            _freqBand[i] = average * 10;

        }
    }

    /* samples de Frecuencia a 64
     0 - 15 = 1 sample =16
     16 - 31 = 2 samples = 32
     32 - 39 = 4 samples = 32
     40 - 47 = 6 samples = 48
     48 - 55 = 16 samples = 128
     56 - 63 = 32 samples = 256
     */

    void MakeFrequencyBands64()
    {
        int count = 0;
        int sampleCount = 1;
        int power = 0;

        for (int i = 0; i < 64; i++)
        {
            float average = 0;


            if (i == 16 || i == 32 || i == 40 || i == 48 || i == 56)
            {
                power++;
                sampleCount = (int)Mathf.Pow(2, power);

                if (power == 3)
                {
                    sampleCount -= 2;
                }
            }
            for (int j = 0; j < sampleCount; j++)
            {
                if (channel == _channel.stereo)
                {
                    average += _samplesLeft[count] + _samplesRight[count] * (count + 1);
                }
                if (channel == _channel.Left)
                {
                    average += _samplesLeft[count] * (count + 1);
                }
                if (channel == _channel.Right)
                {
                    average += _samplesRight[count] * (count + 1);
                }

                count++;
            }

            average /= count;
            _freqBand64[i] = average * 80;

        }
    }

}
