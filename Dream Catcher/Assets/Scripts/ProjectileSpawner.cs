using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : Spawner
{

    public float launchHeight;
    public float launchLength; 

    protected override void SpawnInstance()
    {

        GameObject instance = Instantiate(spawnInstance, transform.position, Quaternion.identity);
        Rigidbody2D rb = instance.GetComponent<Rigidbody2D>();
        rb.AddForce(Vector2.up * launchHeight, ForceMode2D.Impulse);
        rb.AddForce(Vector2.left * launchLength, ForceMode2D.Impulse);

    }

}
