using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayersHP : MonoBehaviour
{
    public float PlayerHP;
    public float DamageTimer = 0f;
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        PlayerHP = 100;
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        for (int i = 0; i < enemies.Length; i++)
        {
            if (collision.gameObject.name == enemies[i].name)
            {
                PlayerHP -= 10;
            }
        }
    }
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (transform.position.y < -1)
        {
            if (DamageTimer <= 0f)
            {
                MinusHP();
                DamageTimer = 2f;
            }
            else
            {
                DamageTimer -= 0.5f;
            }
        }
    }
    public void MinusHP()
    {
        PlayerHP -= 10;
        if (PlayerHP < 0)
        {
            Debug.Log("Dead");
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
