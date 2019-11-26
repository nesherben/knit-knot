using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pantallaCorrecta : MonoBehaviour
{
    public GameObject slider,mute;

    public void Update()
    {

        if (SceneManager.GetActiveScene().name == "AJUSTES")
        {

            slider.SetActive(true);

        }
        else { slider.SetActive(false); }
        if ((SceneManager.GetActiveScene().name == "AJUSTES" || SceneManager.GetActiveScene().name == "BIENVENIDA"))
        {

            mute.SetActive(false);

        }
        else { mute.SetActive(true); }
    }
}
