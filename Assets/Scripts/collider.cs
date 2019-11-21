using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider : MonoBehaviour
{

    public GameObject gameobject;
    Transform posicion;
    Vector3 mousePosition;

    private void Start()
    {
        posicion = gameobject.GetComponent<Transform>();
        
    }

    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        mousePosition = Input.mousePosition;
        mousePosition.z = -220;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
    }
    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("cubo choca");
    }
}
