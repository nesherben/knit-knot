using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float velocidad = 3.0f;
    private GameObject cilindro;

    void Start() {

    }

    void Update()
    {
        transform.Rotate(Vector3.up, velocidad * Time.deltaTime);
    }
}
