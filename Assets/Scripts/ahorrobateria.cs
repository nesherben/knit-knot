using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

public class ahorrobateria : MonoBehaviour
{
    public GameObject boton;
    public Sprite activo, inactivo;
    public Button cambio;
    public static bool ahorro = false;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.SetQualityLevel(1, true);
        Debug.Log(QualitySettings.GetQualityLevel());
         cambio = boton.GetComponent<Button>();
        if (!ahorro) {
            cambio.image.sprite = inactivo;
        }
        else cambio.image.sprite = activo;
    }

    public void cambiarModo() {

        if (!ahorro)
        {
            cambio.image.sprite = activo;
            ahorro = true;
            QualitySettings.SetQualityLevel(0, true);
            
        }
        else
        {
            cambio.image.sprite = inactivo;
            QualitySettings.SetQualityLevel(1, true);
            ahorro = false;
           
            
        }
    }
    
}
