using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Spawner : MonoBehaviour
{
    public GameObject[] obstaclePatterns;

    private float timeBtwSpawn;
    public float startTimeBtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    public int lastPatterns;

    private void Update()
    {
        if (timeBtwSpawn <=0)
        {
            
            int rand = Random.Range(0, obstaclePatterns.Length);
           // Debug.Log(rand);
            if (lastPatterns == rand) {
                Debug.Log("It Work");
                return;
            }
            lastPatterns = rand;
            //Debug.Log(lastPatterns);
            Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);

            timeBtwSpawn = startTimeBtwSpawn;
            if (startTimeBtwSpawn > minTime)
            {
                startTimeBtwSpawn -= decreaseTime;

            }
       

        }
        else
        {
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
