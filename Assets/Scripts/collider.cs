
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{

    public GameObject gameobject;
    public GameObject[] pared,checkpoint;
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
        if (Input.GetMouseButtonDown(0))
        {
            isMousePressed = true;
        }
         
        //esto es solo para PC
            if (Input.GetMouseButtonUp(0)) {
            isMousePressed = false;
        }
        
        mousePosition = Input.mousePosition;
        mousePosition.z = 90;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        posicion.position = mousePosition;
    }
    private void OnTriggerEnter(Collider collision)
    {
        
            if (isMousePressed && collision.tag == "limite")
            {
            for (int i = 0; i < pared.Length; i++)
                {
                    pared[i].GetComponentInChildren<Renderer>().material.SetColor("_Color", Color.red);
                    Debug.Log("cubo choca");
                }
            }
        
            for (int x = 0; x < checkpoint.Length; x++)
            {
                if (isMousePressed && collision.tag == "control") //hay que arreglar, que detecta todas y no puede ser
                {
                    checkpoint[x].name.ToString();
                    Debug.Log(checkpoint[x].name.ToString());
                }
            }
    }   
    private void OnTriggerExit(Collider collision)
    {
        
            if (isMousePressed && collision.tag == "limite")
            {
            for (int i = 0; i < pared.Length; i++)
                {
                    pared[i].GetComponentInChildren<Renderer>().material.SetColor("_Color", Color.black);
                    Debug.Log("cubo no choca");
                }
            }
    }
}
