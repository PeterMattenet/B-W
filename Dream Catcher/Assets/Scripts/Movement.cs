using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    Rigidbody2D rb;
    [SerializeField] float moveSpeed = 4;
    [SerializeField] float jumpHeight = -4;
    bool onGround = true; 
    //canMove is set to true if move timer is < 1
    public bool canMove = true;
    //Move timer determines if we can move. If it's above 0, we cannot. Used by hazards to slow us down.
    public float moveTimer = 0;
    public LayerMask groundLayer;
    public Transform feetPos;

    private void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    private void Update()
    {
        onGround = Physics2D.OverlapCircle(feetPos.position, 0.1f, groundLayer);
        MoveTimer();

    }

    //This moves the object in the intended direction based on their move speed. Called by the input script of the object
    public void Move(Vector2 direction)
    {
        if (canMove)
        {
            rb.velocity = new Vector2(direction.x * moveSpeed, rb.velocity.y);
        }
    }

    public void Jump()
    {

        if (onGround)
        {

            rb.AddForce(Vector2.up * jumpHeight, ForceMode2D.Impulse);

        }

    }

    void MoveTimer()
    {

        if (moveTimer > 0)
        {

            canMove = false;
            //Ensures that it doesn't go below 0 whilst ticking down by 1 each second
            moveTimer = Mathf.Clamp(moveTimer, 0, 1 * Time.deltaTime);

        }
        else
        {

            canMove = true; 

        }

    }

}
