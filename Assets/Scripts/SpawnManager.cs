using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] obstacles;

    private float startDelay = 2.0f;
    private int spawnInterval;

    void Start()
    {
        spawnInterval = (int)Random.Range(1f, 5f);
        InvokeRepeating("SpawnRandomObstacle", startDelay, spawnInterval);
    }

    void SpawnRandomObstacle()
    {
            int obstacleIndex = Random.Range(0, obstacles.Length);
            Instantiate(obstacles[obstacleIndex], new Vector3(Random.Range(-9, 5), 0, 5), obstacles[obstacleIndex].transform.rotation);
    }

    private void OnDisable()
    {
        CancelInvoke();
    }

    private void OnEnable()
    {
        Start();
    }
}
