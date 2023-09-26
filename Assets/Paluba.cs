using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paluba : MonoBehaviour
{
    public GameObject player;
    public GameObject plot;
    public Transform palub;
    public Transform plotr;
    public float speed;
    private void LateUpdate()
    {
        plot.transform.Translate(Vector3.left * Time.deltaTime * speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        if (other.gameObject.tag == "enterPalub")
            player.transform.position = palub.position;
        else if (other.gameObject.tag == "exitPalub")
            player.transform.position = plotr.position;
    }
}
