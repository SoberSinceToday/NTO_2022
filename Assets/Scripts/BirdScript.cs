using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class BirdScript : MonoBehaviour
{
    public float speed = 1f;
    float KdPoleta = 10f;
    public void Start()
    {
    }
    // Update is called once per frame
    /*void Update()
    {
        KdPoleta -= Time.deltaTime;
        if (KdPoleta > 0)
        {
            Vector3 movementDirection = new Vector3(Random.RandomRange(0, 10), 0, Random.RandomRange(0, 10));
            movementDirection = Vector3.ClampMagnitude(movementDirection, 1);
            transform.Translate(movementDirection * speed * Time.deltaTime);
        }
        else if (KdPoleta > -10)
        {
            Vector3 movementDirection = new Vector3(Random.RandomRange(-10, 0), 0, Random.RandomRange(-10, 0));
            movementDirection = Vector3.ClampMagnitude(movementDirection, 1);
            transform.Translate(movementDirection * speed * Time.deltaTime);

        }
        else
        {
            KdPoleta = 10;
        }
        Debug.Log(KdPoleta);
    }*/
    private void Update()
    {
        Vector3 movementDirection = new Vector3(Random.RandomRange(0, 10), 0, Random.RandomRange(0, 10));
        movementDirection = Vector3.ClampMagnitude(movementDirection, 1);
        transform.Translate(movementDirection * speed * Time.deltaTime);
    }
}
