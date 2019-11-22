using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{

    public GameObject gameobject,pared;
    Transform posicion;
    Vector3 mousePosition;
    bool isMousePressed = false;
    private void Start()
    {
        posicion = gameobject.GetComponent<Transform>();
        
        
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            isMousePressed = true;
        }
        mousePosition = Input.mousePosition;
        mousePosition.z = 90;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        posicion.position = mousePosition;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (isMousePressed)
        {
            pared.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            Debug.Log("cubo choca");
        }
    }
    private void OnTriggerExit(Collider collision)
    {
        if (isMousePressed)
        {
            pared.GetComponent<Renderer>().material.SetColor("_Color", Color.black);
            Debug.Log("cubo no choca");
        }
    }
}
