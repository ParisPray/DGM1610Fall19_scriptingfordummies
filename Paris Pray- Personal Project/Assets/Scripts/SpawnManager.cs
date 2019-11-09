using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] treasurePrefabs;
    private float spawnRangeX = 30;
    private float spawnPosZ = 20;
    private float spawnPosY = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomTreasure", startDelay, spawnInterval);

    }


    // Update is called once per frame
    void Update()
    {
      
    }
    void SpawnRandomTreasure()
    {
        int treasureIndex = Random.Range(0, treasurePrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 20, spawnPosY);

        Instantiate(treasurePrefabs[treasureIndex], spawnPos, treasurePrefabs[treasureIndex].transform.rotation);
    }
}
