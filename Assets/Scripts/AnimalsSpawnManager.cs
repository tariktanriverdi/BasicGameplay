using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    public float swapnRangeX = 20;
    public float swapnRangeZp = 10;
    public float swapnRangeZn = -20;
    public float startDelay = 2f;
    public float spawnInterval = 1.5f;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // ctrl+d 
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.RandomRange(-swapnRangeX, swapnRangeX), 0, Random.RandomRange(swapnRangeZn, swapnRangeZp));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
}
