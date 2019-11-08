using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class scenemanager : MonoBehaviour, IPointerClickHandler
{

    public string escena;
    

    public void OnPointerClick(PointerEventData eventData) // 3
    {
        SceneManager.LoadScene(escena);
    }

    public void loadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

}
