using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class abrirAyuda : MonoBehaviour
{
    public GameObject mensajeAyuda;
    public void OnPointerClick() // 3
    {
        mensajeAyuda.SetActive(true);
    }
}
