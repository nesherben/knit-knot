using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class muteAudio : MonoBehaviour
{
    public static Button cambio;
    public GameObject boton;
    public Sprite activo, inactivo;
    public AudioMixer miaudio;
    public static bool muted = false;
    public static float volumen,saved;

    private void Start()
    {
        cambio = boton.GetComponent<Button>();
        volumen = audioControl.saveValue;
        miaudio.SetFloat("musicVol", Mathf.Log10(volumen) * 20);
        
    }

    public void muteado() {
        
        saved = volumen;
        if (!muted || volumen == 0)
        {
            miaudio.SetFloat("musicVol", Mathf.Log10(0) * 20);
            muted = true;
            audioControl.saveValue = -1;
            cambio.image.sprite = activo;
        }
        else
        {

            cambio.image.sprite = inactivo;
            miaudio.SetFloat("musicVol", Mathf.Log10(saved) * 20);
            audioControl.saveValue = saved;
            muted = false;
        }

    }



}
             
       