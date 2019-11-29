using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puntuacion : MonoBehaviour
{

    public static float total = 0;
    public GameObject gestion;
    bool done = false;
    public GameObject[] estrellitas;
    public GameObject[] textos;

    static float save1, save2;
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
        
    }
   
    public static void calculoPuntos()

    {
        save1 += mycollider.checkpass * 100 / 6;
        save2 += mycollider.wallcoll * 23f / 3f;
        total = save1 - save2;
    }
    public void mostrarScore() {
        gestion.GetComponentInChildren<Canvas>().enabled = true;
        total = total/3f;
        if (total > 90) {
            Debug.Log("perfecto");
            estrellitas[0].SetActive(true);
            estrellitas[1].SetActive(true);
            estrellitas[2].SetActive(true);
            textos[3].SetActive(true);
        }
        if (total > 45 && total < 90) {
            Debug.Log("2 estrellas");
            estrellitas[0].SetActive(true);
            estrellitas[1].SetActive(true);
            textos[2].SetActive(true);
        }
        if (total > 0 && total< 45) {
            Debug.Log("1 estrella");
            estrellitas[0].SetActive(true);
            textos[1].SetActive(true);

        }
        if (total< 0) {
            Debug.Log("fatal");
            textos[0].SetActive(true);
        }
        
    }


}
