using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class muteAudio : MonoBehaviour
{
    public Button cambio;
    public Slider slider;
    public GameObject boton;
    public Sprite activo, inactivo;
    public AudioMixer miaudio;
    public bool muted = false;
    public float volumen,saved;
    
    
    public void Start()
    {
        saved = 1f;
        cambio = boton.GetComponent<Button>();
        miaudio.SetFloat("musicVol", Mathf.Log10(saved) * 20);
        
    }

    public void muteado() {
        
        if (!muted)
        {
            slider.value = -1;
            miaudio.SetFloat("musicVol", Mathf.Log10(-1) * 20);
            muted = true;
            cambio.image.sprite = activo;
            
        }
        else
        {
            slider.value = saved;
            cambio.image.sprite = inactivo;
            miaudio.SetFloat("musicVol", Mathf.Log10(slider.value) * 20);
            muted = false;
        }

    }
    public void setvolume()
    {
        miaudio.SetFloat("musicVol", Mathf.Log10(slider.value) * 20);
        saved = slider.value;
    }
    


}
             
       