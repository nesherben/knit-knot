using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puntuacion : MonoBehaviour
{

    public float total;
    public GameObject gestion;
    bool done = false;
    public GameObject[] estrellitas;
    public GameObject[] textos;

    static float save1, save2;
    private void Start()
    {
        total = 0;
        save1 = 0;
        save2 = 0;
    }

    private void Update()
    {
        Debug.Log(total);
        if (SceneManager.GetActiveScene().name != "RESULTADOS")
            {
                DontDestroyOnLoad(gestion);
                gestion.GetComponentInChildren<Canvas>().enabled = false;
                
            }
        else if(!done){
                done = true;
                mostrarScore();
        }
        if (SceneManager.GetActiveScene().name == "MENU") Destroy(gestion);
        
    }
   
    public static void calculoPuntos()

    {
        save1 += mycollider.checkpass * 100 / 6;
        save2 += mycollider.wallcoll * 24.16f / 2.78f;
        
    }
    public void mostrarScore() {
        total = save1 - save2;
        gestion.GetComponentInChildren<Canvas>().enabled = true;
        total = total/3f;
        if (total > 90) {
            Debug.Log("perfecto");
            estrellitas[0].SetActive(true);
            estrellitas[1].SetActive(true);
            estrellitas[2].SetActive(true);
            textos[3].SetActive(true);
        }
        if (total > 50 && total < 90) {
            Debug.Log("2 estrellas");
            estrellitas[0].SetActive(true);
            estrellitas[1].SetActive(true);
            textos[2].SetActive(true);
        }
        if (total > 10 && total< 50) {
            Debug.Log("1 estrella");
            estrellitas[0].SetActive(true);
            textos[1].SetActive(true);

        }
        if (total< 10) {
            Debug.Log("fatal");
            textos[0].SetActive(true);
        }
    }


}
