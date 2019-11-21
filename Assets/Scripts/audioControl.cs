using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class audioControl : MonoBehaviour
{
    public Slider slider;
    public AudioMixer mixer;
    public static float saveValue = 1;
    public void setvolume(float sliderValue)
    {
        mixer.SetFloat("musicVol",Mathf.Log10(sliderValue)*20);
        saveValue = sliderValue;
    }
    private void Awake()
    {
        slider.value = saveValue;
    }
}