using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundHazard : Hazard
{
    Rigidbody2D rb;
    //Higher the value, the faster the speed. Made negative in the movement to go left. 
    [SerializeField] float moveSpeed;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    private void FixedUpdate()
    {

        rb.velocity = new Vector2(-moveSpeed, rb.velocity.y);

    }

}
