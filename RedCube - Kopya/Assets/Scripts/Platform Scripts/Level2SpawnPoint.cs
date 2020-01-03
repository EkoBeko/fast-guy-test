using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2SpawnPoint : MonoBehaviour
{
    public GameObject obstacle;
    void Start()
    {
        Instantiate(obstacle, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
