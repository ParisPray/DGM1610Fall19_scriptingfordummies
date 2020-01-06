using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] treasurePrefabs;

    private float spawnRangeXLeft = -20;

    private float spawnRangeXRight = 20;

    private float spawnPosY = 20;

    private float startDelay = 2.0f;

    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        // spawns a random treasure object

        InvokeRepeating("SpawnRandomTreasure", startDelay, spawnInterval);

    }


    // Update is called once per frame
    void Update()
    {
      
    }

    // Spawns a random treasure someplace from above.

    void SpawnRandomTreasure()
    {
        int treasureIndex = Random.Range(0, treasurePrefabs.Length);

        Vector3 spawnPos = new Vector3(Random.Range(spawnRangeXLeft, spawnRangeXRight), spawnPosY, 0);

        Instantiate(treasurePrefabs[treasureIndex], spawnPos, treasurePrefabs[treasureIndex].transform.rotation);
    }
}
