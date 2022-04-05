using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnInstance;
    [SerializeField] float spawnInterval;
    //Used to determine how far we stray from the spawnInterval variable to add element of randomness to spawn timing
    //MUST BE LOWER THAN SPAWN INTERVAL
    [SerializeField] float IntervalVariance;
    float spawnTimer;

    private void Start()
    {

        spawnTimer = spawnInterval;

    }

    // Update is called once per frame
    void Update()
    {

        SpawnTimer();

    }

    protected virtual void SpawnInstance()
    {

        Instantiate(spawnInstance, transform.position, Quaternion.identity);

    }

    void SpawnTimer()
    {

        if (spawnTimer < 1)
        {

            SpawnInstance();
            spawnTimer = spawnInterval + Random.Range(-IntervalVariance, IntervalVariance);

        }
        else
        {

            spawnTimer -= Time.deltaTime;

        }

    }
}
