using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistencia : MonoBehaviour
{
    //public int esperableInput = 4;
    public GameObject[] objs;
    
    void Awake()
    {
        objs = GameObject.FindGameObjectsWithTag("persistencia");

        if (objs.Length > 4)
        {
            Debug.Log("ff");
            Destroy(this.gameObject);
        }
        Debug.Log("dd");
        DontDestroyOnLoad(this.gameObject);
    }
}
