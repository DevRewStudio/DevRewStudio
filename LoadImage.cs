// This Script From Load Image From URL

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadImage : MonoBehaviour
{
    public string url = "https://www.google.com/";
    public Renderer thisRenderer;

    void Start()
    {
        StartCoroutine(LoadFromLikeCoroutine()); 

        thisRenderer.material.color = Color.red;
    }

    // this section will be run independently
    private IEnumerator LoadFromLikeCoroutine()
    {
        Debug.Log("Loading ....");
        WWW wwwLoader = new WWW(url);  
        yield return wwwLoader;        

        Debug.Log("Loaded");
        thisRenderer.material.color = Color.white;             
        thisRenderer.material.mainTexture = wwwLoader.texture;  
    }
}
