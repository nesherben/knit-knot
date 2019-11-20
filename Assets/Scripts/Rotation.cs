using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float velocidad = 2.0f;
    public GameObject obj;

    void Start() {

    }

    void Update()
    {
        if (!ahorrobateria.ahorro)
        {
            obj.transform.Rotate(Vector3.up, velocidad * Time.deltaTime);
        }
    }

}
