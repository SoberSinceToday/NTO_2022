using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RifsGener : MonoBehaviour
{
    public GameObject[] riefs;
    public List<Transform> spawnPoints = new List<Transform>();
    public void Start()
    {
        SpawnEl();
    }
    public void SpawnEl()
    {
        for (int i = 0; i < 5; i++)
        {
            int randomNumber = Random.Range(0, spawnPoints.Count);
            GameObject loot = SpawnLoot(spawnPoints[randomNumber]);
            spawnPoints.RemoveAt(randomNumber);
        }
    }
    private GameObject SpawnLoot(Transform spawnPoint)
    {
        var prefab = riefs[Random.Range(0, riefs.Length)];
        return Instantiate(prefab, spawnPoint.position, spawnPoint.rotation);
    }
}