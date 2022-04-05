using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    [SerializeField] float bumpForce;
    [SerializeField] float bumpDuration;

    protected virtual void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Player"))
        {

            Movement playerMovement = collision.gameObject.GetComponent<Movement>();
            playerMovement.Bump(Vector2.left, bumpForce, bumpDuration);
            Destroy(gameObject);

        }

    }


}
