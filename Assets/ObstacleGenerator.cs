using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f;
    public float spawnRange = 2f;

    float nextSpawnTime;

    void Start()
    {
        nextSpawnTime = Time.time + spawnInterval;
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnObstacle();
            nextSpawnTime = Time.time + spawnInterval;
        }
    }

    void SpawnObstacle()
    {
        float randomY = Random.Range(-spawnRange, spawnRange);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomY, 0f);
        Instantiate(obstaclePrefab, spawnPosition, Quaternion.identity);
    }
}