using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bienvenidoload : MonoBehaviour
{
    public GameObject logo;
    Vector3 boing;
    
    public float multiplier;
    void Awake()
    {
        boing = logo.GetComponent<Transform>().localScale;

    }
    void Update()
    {

        multiplier = Mathf.Sin(Time.time);
        boing.x = boing.x * 1 + multiplier / 16;
        boing.y = boing.y * 1 + multiplier / 16;
        boing.z = boing.z * 1 + multiplier / 16;
        logo.transform.localScale = new Vector3(boing.x, boing.y, boing.z);
        
    }


}
