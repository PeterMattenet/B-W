using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInput : MonoBehaviour
{
    public Transform jumpSensor;
    public float jumpSensorDistance = 3;
    RaycastHit2D jumpInput;
    public LayerMask hazardLayer; 
    Movement enemyMovement;

    private void Start()
    {

        enemyMovement = GetComponent<Movement>();

    }

    private void Update()
    {

        jumpInput = Physics2D.Raycast(jumpSensor.position, Vector2.right, jumpSensorDistance, hazardLayer);

    }

    private void FixedUpdate()
    {
        
        if (jumpInput)
        {
            Debug.Log("HIT");
            enemyMovement.Jump();

        }

    }
}
