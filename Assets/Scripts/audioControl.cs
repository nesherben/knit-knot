﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class audioControl : MonoBehaviour
{
    public AudioMixer mixer;
    public void setvolume(float sliderValue)
    {
        mixer.SetFloat("musicVol",Mathf.Log10(sliderValue)*20);
    }
}