using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject[] platforms;

    public string LastspawnPoints="";

    private float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public Transform randomSpawnPoint;
    public GameObject randomPlatform;


    void Update()
    {
        Spawn();


    }

    public void Spawn()
    {
        if (timeBtwSpawns <= 0)
        {
            //Spawn Hazard

            Transform randomSpawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
            GameObject randomPlatform = platforms[Random.Range(0, platforms.Length)];

            if (randomSpawnPoint.gameObject.name == "SpawnPoint" && LastspawnPoints == "SpawnPoint (2)")
            {
                Debug.Log("right to left");
                Spawn();
                return;
            }
            else if (randomSpawnPoint.gameObject.name == "SpawnPoint (2)" && LastspawnPoints == "SpawnPoint")
            {
                Debug.Log("left to right");
                Spawn();
                return;
            }


            Instantiate(randomPlatform, randomSpawnPoint.position, Quaternion.identity);

            timeBtwSpawns = startTimeBtwSpawns;
            LastspawnPoints = randomSpawnPoint.gameObject.name;
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
