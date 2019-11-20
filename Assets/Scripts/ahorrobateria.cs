using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class ahorrobateria : MonoBehaviour
{
    public GameObject boton;
    public Sprite activo, inactivo;
    public static bool ahorro = false;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.SetQualityLevel(1, true);
        Debug.Log(QualitySettings.GetQualityLevel());
    }

    public void cambiarModo() {

        if (!ahorro)
        {
            ahorro = true;
            QualitySettings.SetQualityLevel(0, true);
            Debug.Log("clickado ahorro");
            Debug.Log(QualitySettings.GetQualityLevel());
        }
        else
        {
            QualitySettings.SetQualityLevel(1, true);
            ahorro = false;
            Debug.Log("clickado no ahorro");
            Debug.Log(QualitySettings.GetQualityLevel());
        }
    }
    
}
