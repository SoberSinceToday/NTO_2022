using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OceanManager : MonoBehaviour
{
    public float waveHeight = 0.5f;
    public float waveFrequency = 1f;
    public float waveSpeed = 1f;
    public GameObject ocean;

    Material oceanMat;
    Texture2D displacementWaves;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void SetVariables()
    {
        oceanMat =ocean.GetComponent<Renderer>().sharedMaterial;
        displacementWaves = (Texture2D)oceanMat.GetTexture("_Displacement");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
