using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting;

public class Errorpopup : MonoBehaviour
{
    public GameObject error;

    public void sale(Transform canvasparent) {
        
        Instantiate(error, new Vector3(0, 0,-200), Quaternion.identity, canvasparent);

    }

     public void destruir() {
        Destroy(error);
    }
}
