using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnInstance;
    [SerializeField] float spawnInterval;
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
            spawnTimer = spawnInterval;

        }
        else
        {

            spawnTimer -= Time.deltaTime;

        }

    }
}
