using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableLinea : MonoBehaviour
{
    public GameObject linea;
    public void disableLinea() {
        
        linea.GetComponentInChildren<Linerender>().enabled = !linea.GetComponentInChildren<Linerender>().enabled;


    }
}
