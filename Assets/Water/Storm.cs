using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Storm : MonoBehaviour
{
    public Material mt;
    void Start()
    {
        mt.SetFloat("Displacement", 1);
    }


}
