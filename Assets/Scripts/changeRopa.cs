using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeRopa : MonoBehaviour
{
    public GameObject ropa;
    public GameObject cubo;

    public void cambiador() {


        ropa.transform.position = cubo.transform.position;
        cubo.transform.position = new Vector3(0, 0, 0);
    }
}
