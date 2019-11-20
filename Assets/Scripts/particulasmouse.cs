using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particulasmouse : MonoBehaviour
{
    public GameObject particula;
    ParticleSystem aparece;
    Transform posicion;
    Vector3 mousePosition;

    private void Start()
    {
        posicion = particula.GetComponent<Transform>();
        aparece = particula.GetComponent<ParticleSystem>();
        
    }
    
    // Start is called before the first frame update
    public void onclick() {
        
    }
    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = 10;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        posicion.position = mousePosition;
        if ((Input.GetMouseButtonDown(0) || Input.GetMouseButtonDown(1)) && !ahorrobateria.ahorro)
        {
            aparece.Play();
        }
    }
}
