using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class Errorpopup : MonoBehaviour
{
    public GameObject error;

    public void sale() {

        error.GetComponent<Canvas>().enabled = true;
    }
    
}
