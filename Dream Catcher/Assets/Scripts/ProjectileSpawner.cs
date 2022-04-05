using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : Spawner
{

    public float launchHeight;
    public float launchLength;
    [SerializeField] float launchHeightVariance;
    [SerializeField] float launchLengthVariance;

    protected override void SpawnInstance()
    {

        float thisLaunchHeight = launchHeight + Random.Range(-launchLengthVariance, launchHeightVariance);
        float thisLaunchLength = launchLength + Random.Range(-launchLengthVariance, launchLengthVariance);

        GameObject instance = Instantiate(spawnInstance, transform.position, Quaternion.identity);
        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * thisLaunchHeight, ForceMode2D.Impulse);
        rb.AddForce(Vector2.left * thisLaunchLength, ForceMode2D.Impulse);

    }

}
