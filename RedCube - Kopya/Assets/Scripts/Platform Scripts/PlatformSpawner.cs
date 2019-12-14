using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformSpawner : MonoBehaviour
{
    public GameObject platformPrefab;
    public GameObject spikePlatformPrefab;
    public GameObject[] movingPlatform;
    public GameObject breakablePlatform;
    public float platformSpawn_Timer = 1.8f;
    private float currentPlatformSpawn_Timer;

    private int platformSpawn_Count;

    public float min_X =-2, max_X=2f;
    void Start()
    {
        currentPlatformSpawn_Timer = platformSpawn_Timer;
    }

    // Update is called once per frame
    void Update()
    {
        SpawnPlatforms();
    }

    void SpawnPlatforms()
    {
        currentPlatformSpawn_Timer += Time.deltaTime;
        if (currentPlatformSpawn_Timer >= platformSpawn_Timer) {

            platformSpawn_Count++;

            Vector3 temp = transform.position;
            temp.x = Random.Range(min_X, max_X);

            GameObject newPlatform = null;

            if (platformSpawn_Count < 2)
            {
                newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
            }
            else if (platformSpawn_Count == 2)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(movingPlatform[Random.Range(0,movingPlatform.Length)], temp, Quaternion.identity);
                }
            }
            else if (platformSpawn_Count == 3)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(spikePlatformPrefab, temp, Quaternion.identity);
                }
            }
            else if (platformSpawn_Count == 4)
            {
                if (Random.Range(0, 2) > 0)
                {
                    newPlatform = Instantiate(platformPrefab, temp, Quaternion.identity);
                }
                else
                {
                    newPlatform = Instantiate(breakablePlatform, temp, Quaternion.identity);
                }
                platformSpawn_Count = 0;
            }
            if(newPlatform)
                newPlatform.transform.parent = transform;

            currentPlatformSpawn_Timer = 0f;
        }//Spawn Platform

    }
}
