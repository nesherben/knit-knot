using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starRotation : MonoBehaviour
{
    public float velocidad = 35.0f;
	//private GameObject estrellita;

    void Start() {

    }

    void Update()
    {
        if (!ahorrobateria.ahorro)
        {
            transform.Rotate(Vector3.forward, velocidad * Time.deltaTime);
        }
    }
}
