
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mycollider : MonoBehaviour
{

    [SerializeField] public string escenaSiguiente;
    public GameObject gameobject;
    public GameObject prefab;
    public GameObject micanvas;
    public GameObject[] pared;
    [SerializeField]public GameObject[] cp;
    public static int checkpass,wallcoll;
    Transform posicion;
    int faketouch = 0;
    bool cierre = false;
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
         
        //esto es solo para PC//
            if (Input.GetMouseButtonUp(0)) {
            
            isMousePressed = false;
            }
        /////////////////////////
        if (!isMousePressed)
        {
            faketouch = 0;
            Destroy(GameObject.FindWithTag("comienzo"));

            for (int i = 0; i < cp.Length; i++)
            {
                cp[i].GetComponentInChildren<SphereCollider>().enabled = true;
                cierre = false;
            }
        }
        if(faketouch<2 && isMousePressed) {
            //te partes de risa con esto, es para que en android vaya bien xd
            Destroy(GameObject.FindWithTag("comienzo"));
            
            Instantiate(prefab, mousePosition, Quaternion.identity).transform.parent = micanvas.transform;
            faketouch++;
           
        }


        Debug.Log(cierre);
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

        
            if (isMousePressed && collision.tag == "control") 
                {
                for (int x = 0; x < cp.Length; x++)
                {
                
                    if (collision.name.Equals(cp[x].name)) {
                        cp[x].GetComponentInChildren<SphereCollider>().enabled = false;
                        checkpass++;
                    }
                }
            }
            if (isMousePressed && collision.tag == "comienzo") {

            Debug.Log("se acabo no mas");
                cierre = true;
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
        if (isMousePressed && collision.tag == "comienzo")
        {

            Debug.Log("salida del inicio");
            cierre = false;
        }
    }

    public void finaljuego() {

        if (cierre && checkpass == cp.Length) {
            Debug.Log("Aqui se choca bien loko");
            puntuacion.calculoPuntos();
            transicion();
        }


    }
    
    void transicion() {
            SceneManager.LoadScene(escenaSiguiente);
    }

}
