
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mycollider : MonoBehaviour
{

    public GameObject gameobject;
    public GameObject[] pared;
    public GameObject[] cp;
    public static int checkpass,wallcoll;
    Transform posicion;
    Vector3 mousePosition;
    bool isMousePressed = false;
    private void Start()
    {
        posicion = gameobject.GetComponent<Transform>();
        checkpass = 0;
        wallcoll = 0;
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
        Debug.Log(checkpass);
        finaljuego();
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
                    
                wallcoll++;
                }
            }

        
            if (isMousePressed && collision.tag == "control") //hay que arreglar, que detecta todas y no puede ser
                {
                for (int x = 0; x < cp.Length; x++)
                {
                
                    if (collision.name.Equals(cp[x].name)) {
                        
                        checkpass++;
                    }
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
                    
                wallcoll++;
                }
            }
    }

    public void finaljuego() {

        if (checkpass == 6 && Linerender.isLineCollide()) {

            calculoPuntos();

        }


    }
    void calculoPuntos() {

        float total = 0;
        total = (checkpass * 100/6)-(wallcoll*10/6);

        if (total > 90) {
            Debug.Log("perfecto");
        }
        else if (total > 60 && total < 90) {
            Debug.Log("2 estrellas");
        }
        else if (total > 50 && total < 60) {
            Debug.Log("1 estrella");
        }
        else
        {
            Debug.Log("Fallado.");
        }
        transicion();
    }

    void transicion() {
        float x = 0;
        Debug.Log(x);

        while (x < 9000) {

            x++;

        }



        if (x > 6000) {

            SceneManager.LoadScene("MENU");
        }

    }

}
