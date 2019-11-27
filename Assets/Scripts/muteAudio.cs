using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class muteAudio : MonoBehaviour
{
    public Image cambio;
    public Slider slider;
    public GameObject boton,sonido;
    public Sprite activo, inactivo;
    AudioSource miaudio;
    public bool muted = false;
    public float volumen, saved;


    
    private void Start()
    {
        saved = 1f;
        miaudio = sonido.GetComponent<AudioSource>();
        cambio = boton.GetComponent<Image>();
        miaudio.volume = saved;
        
        
    }

    public void muteado() {

        if (!muted)
        {
            slider.value = 0;
            miaudio.volume = slider.value;
            muted = true;
            cambio.sprite = activo;
            
        }
        else
        {
            cambio.sprite = inactivo;
            slider.value = saved;
            miaudio.volume = saved;
            muted = false;
            
        }
        //setvolume();
    }
    public void setvolume()
    {
        miaudio.volume = slider.value;
        saved = slider.value;
    }
    


}
             
       