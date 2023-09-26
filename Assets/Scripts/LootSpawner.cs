using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootSpawner : MonoBehaviour
{
    public GameObject[] myObjects;

    float RespawnTime = 2f;
    // Update is called once per frame
    void Update()
    {
        RespawnTime -= Time.deltaTime;
        if (RespawnTime <= 0)
        {
            int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 RandomSpawnPosition = new Vector3(Random.Range(-10, 11), 1, Random.Range(-10, 11)); //www.youtube.com/watch?v=bIM3VAiZHeQ&ab_channel=UnityAceY93XJOyGwPAPzayJiAo_37
            Instantiate(myObjects[randomIndex], RandomSpawnPosition, Quaternion.identity);
            //Debug.Log("SpawnedSomeTrash");
            RespawnTime = 2f;
        }
    }
}