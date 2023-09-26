using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHungry : MonoBehaviour
{
    public float HungryScale;
    public float FoodDamage = 2f;
    // Start is called before the first frame update
    void Start()
    {
        HungryScale = 150;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        if (FoodDamage> 0)
        {
            FoodDamage -= Time.deltaTime;
        }
        else
        {
            FoodDamage = 2f;
            HungryScale -= 10;
        }
    }
}
