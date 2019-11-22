using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
public class audioControl : MonoBehaviour
{
    public Slider slider;
    public AudioMixer mixer;
    public static float saveValue = 1f;
    public void setvolume(float sliderValue)
    {
        mixer.SetFloat("musicVol",Mathf.Log10(sliderValue)*20);
        saveValue = sliderValue;
    }
    
    private void Awake()
    {
        Debug.Log(muteAudio.volumen);

        slider.value = saveValue;
    }

}