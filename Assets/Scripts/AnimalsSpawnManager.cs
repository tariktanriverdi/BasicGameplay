using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalsSpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; 
    public float swapnRangeX=20;
    public float swapnRangeZ=20;
    void Start()
    {
        
    }

    // ctrl+d 
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S)){
            int animalIndex=Random.Range(0,animalPrefabs.Length);
            Vector3 spawnPos=new Vector3(Random.RandomRange(-swapnRangeX,swapnRangeX),0,Random.RandomRange(-swapnRangeZ,swapnRangeZ));
            Instantiate(animalPrefabs[animalIndex],spawnPos,animalPrefabs[animalIndex].transform.rotation);
            
        }
    }
}
