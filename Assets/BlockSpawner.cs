using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BlockSpawner : MonoBehaviour {
    public Transform[] spawnPoints;
    public GameObject[] blockPreFab;
    public float timeToSpawn = 2f;
    public float timeBetweenWaves = 1f;
    private void Start()
    {
        
    }
    void SpawnBlocks(){
        int noSpawnIndex = Random.Range(0,spawnPoints.Length);
        int blockColourIndex = 0;
        if(Time.timeSinceLevelLoad>=10){
            blockColourIndex = 1;
            //Camera.current.backgroundColor = Color.red;
        }
        else if(Time.timeSinceLevelLoad>=5){
            blockColourIndex = 2;
            //Camera.current.backgroundColor = Color.green;
            
        }
        //int blockColourIndex = Random.Range(0, blockPreFab.Length);
        for (int i = 0; i<spawnPoints.Length;i++){
            if(i!=noSpawnIndex){
                Instantiate(blockPreFab[blockColourIndex],spawnPoints[i].position,Quaternion.identity);
            }

        }
    }

    // Update is called once per frame
    void Update () {
        if(Time.timeSinceLevelLoad>=timeToSpawn){
            timeToSpawn += timeBetweenWaves;
            SpawnBlocks();
        }
		
	}
}
