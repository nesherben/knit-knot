using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class changeMaterial : MonoBehaviour
{
    //Set these Textures in the Inspector
    public Texture2D m_MainTexture, m_Normal, m_Metal, m_emision;
    Renderer m_Renterer,c_Renderer;
    //public GameObject combo;
    public GameObject objeto1;
    

    void Start() {
        //Fetch the Renderer from the GameObject
        //c_Renderer = combo.GetComponent<SpriteRenderer>();
        
        m_Renterer = objeto1.GetComponent<MeshRenderer>();

        //Make sure to enable the Keywords
   
        

    }
    // Use this for initialization
    public void setTexture()
    {
       // m_Renterer.material = c_Renderer.material;
        m_Renterer.material.EnableKeyword("_NORMALMAP");
        m_Renterer.material.EnableKeyword("_METALLICGLOSSMAP");
        m_Renterer.material.EnableKeyword("_EMISSION");
        //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
        m_Renterer.material.SetTexture("_MainTex", m_MainTexture);
        //Set the Normal map using the Texture you assign in the Inspector
        m_Renterer.material.SetTexture("_BumpMap", m_Normal);
        //Set the Metallic Texture as a Texture you assign in the Inspector
        m_Renterer.material.SetTexture("_MetallicGlossMap", m_Metal);
        //Set material emissive Texture
        m_Renterer.material.SetTexture("_EmissionMap", m_emision);
        
    }
}
