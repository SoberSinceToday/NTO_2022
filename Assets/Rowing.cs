using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rowing : MonoBehaviour
{
    [SerializeField] private EnemyAI enemyAI;
    public GameObject plot;
    private bool z;
    private bool v;
    public float speed;
    public float rotate;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "leftRow")
            z = true;
        else if (other.gameObject.tag == "rightRow")
            v = true;
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "leftRow")
            z = false;
        else if (other.gameObject.tag == "rightRow")
            v = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "enemy")
            enemyAI.TakeDamage(25);
    }
   
    // Update is called once per frame
    void Update()
    {
        if (z)
        {
            plot.transform.Rotate(0f, 0.05f*rotate, 0f);
        }
        if (v)
        {
            plot.transform.Rotate(0f, -0.05f*rotate, 0f);
        }
        
    }

    
    
}

