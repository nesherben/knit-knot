using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class persistencia : MonoBehaviour
{
    //public int esperableInput = 5;
    public GameObject[] objs;
    
    void Awake()
    {
        objs = GameObject.FindGameObjectsWithTag("persistencia");

        if (objs.Length > 5)//jaja es gracioso porque hay que cambiarlo cada vez
        {
            Debug.Log("ff");
            Destroy(this.gameObject);
        }
        Debug.Log("dd");
        DontDestroyOnLoad(this.gameObject);
    }
}
