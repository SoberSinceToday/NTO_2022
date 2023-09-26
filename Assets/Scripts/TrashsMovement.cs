using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class TrashsMovement : MonoBehaviour
{
    public GameObject myObject;
    public float lifetime = 3f;
    public float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
        if (lifetime > 0)
        {
            lifetime -= Time.deltaTime;
        }
        else
        {
            Destroy(GameObject.Find("Palka(Clone)"));
            lifetime = 3f;
        }            
    }
}//короче тут все оч сыро мы даж не знаем когда будем их удалять так что не буду допиливать.
