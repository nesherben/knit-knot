using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(SpriteRenderer))]

public class spriter : MonoBehaviour
{
    SpriteRenderer rend;
    Texture2D tex;
    public GameObject objeto;
    private static int capas = 2;
    public Texture2D texBase, texPatron;
    public Color texColor;
    Renderer m_Renterer;
    public Texture2D[] textureArray = new Texture2D[capas];
    public Color[] colorArray = new Color[capas];


    // Start is called before the first frame update
    public void Start()
    {
        rend = GetComponent<SpriteRenderer>();
        m_Renterer = objeto.GetComponent<MeshRenderer>();
        //hacer textura

        for (int i = 0; i < capas; i++) {

            textureArray[i] = Texture2D.whiteTexture;
            colorArray[i] = new Color(0, 0, 0, 0);

        }

    }
    public void Update()
    {
        tex = MakeTexture(textureArray, colorArray);
        //hacer sprite

        rend.sprite = MakeSprite(tex);
        setTexture(tex);
    }

    public void trigger()
    {
        setTexture(tex);
        Update();
    }

    public Texture2D MakeTexture(Texture2D[] layers, Color[] layerColors)
    {


        //crear textura
        Texture2D newTexture = new Texture2D(layers[0].width, layers[0].height);
        //array para meter los colores de la textura
        Color[] colorArray = new Color[newTexture.width * newTexture.height];
        //array de colores de la textura
        Color[][] srcArray = new Color[layers.Length][];
        //llenar array
        for (int i = 0; i < layers.Length; i++)
        {
            srcArray[i] = layers[i].GetPixels();
        }


        for (int x = 0; x < newTexture.width; x++)
        {
            for (int y = 0; y < newTexture.height; y++)
            {
                int pixelIndex = x + (y * newTexture.width);
                for (int i = 0; i < layers.Length; i++)
                {
                    Color srcPixel = srcArray[i][pixelIndex];


                    //aplicar color a la capa

                    if (srcPixel.r != 0 && srcPixel.a != 0 && i < layerColors.Length)
                    {
                        srcPixel = applyColorToPixel(srcPixel, layerColors[i]);
                    }


                    //fundir colores
                    if (srcPixel.a == 1)
                    {
                        colorArray[pixelIndex] = srcPixel;
                    }
                    else if (srcPixel.a > 0)
                    {
                        colorArray[pixelIndex] = NormalBlend(colorArray[pixelIndex], srcPixel);
                    }
                }
            }

        }

        newTexture.SetPixels(colorArray);
        newTexture.Apply();

        newTexture.wrapMode = TextureWrapMode.Clamp;
        newTexture.filterMode = FilterMode.Point;
        return newTexture;
    }

    public Sprite MakeSprite(Texture2D texture)
    {
        return Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), Vector2.one * 0.5f);

    }

    Color NormalBlend(Color dest, Color src)
    {

        float srcAlpha = src.a;
        float destAlpha = (1 - src.a) * dest.a;
        Color destLayer = dest * destAlpha;
        Color srcLayer = src * srcAlpha;

        return destLayer + srcLayer;


    }
    Color applyColorToPixel(Color pixel, Color applyColor)
    {

        if (pixel.r == 1f && applyColor.a > 0)
        {
            return pixel;
        }
        return pixel + applyColor;

    }

    void setTexture(Texture2D mitextura)
    {
        // m_Renterer.material = c_Renderer.material;
        m_Renterer.material.EnableKeyword("_NORMALMAP");
        //m_Renterer.material.EnableKeyword("_METALLICGLOSSMAP");
        m_Renterer.material.EnableKeyword("_EMISSION");
        //Set the Texture you assign in the Inspector as the main texture (Or Albedo)
        m_Renterer.material.SetTexture("_MainTex", mitextura);
        //Set the Normal map using the Texture you assign in the Inspector
        //m_Renterer.material.SetTexture("_BumpMap", m_Normal);
        //Set the Metallic Texture as a Texture you assign in the Inspector
        //m_Renterer.material.SetTexture("_MetallicGlossMap", m_Metal);
        //Set material emissive Texture
        m_Renterer.material.SetTexture("_EmissionMap", mitextura);

    }
}
