using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoatHP : MonoBehaviour
{
    public GameObject[] Traps;
    private MeshCollider Sheep;
    public float hp = 1000;
    private MeshCollider Trap;
    // Start is called before the first frame update
    void Start()
    {
        hp = 1000;
    }

    // Update is called once per frame
    void Update()
    {
        if (hp <= 0)
        {
            Death();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < Traps.Length; i++)
        {
            if (collision.gameObject.name == Traps[i].name)
            {
                hp -= 1000;
            }
        }
    }
    public void Attacking(float dmg)
    {
        hp -= dmg;
    }
    private void Death()
    {
        Debug.Log("DeadBoat");
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
