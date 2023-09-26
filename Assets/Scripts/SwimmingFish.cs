using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwimmingFish : MonoBehaviour
{
    public Transform Fish;
    public float ms;
    // Start is called before the first frame update
    void Start()
    {
        ms = 2;
    }

    // Update is called once per frame
    void Update()
    {
        float length = Vector3.Distance(Fish.position, transform.position);
        if (length >= 5)
        {
            transform.Translate(Vector3.left * ms * Time.deltaTime);
            if (transform.position.x < -21f)
            {
                ms = -ms;
            }
            if (transform.position.x > 21)
            {
                ms = 2;
            }
        }
        else
        {
            float step = ms * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, Fish.position, -step);
        }
    }
}
