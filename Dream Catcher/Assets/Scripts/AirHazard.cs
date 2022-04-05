using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirHazard : Hazard
{

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        base.OnCollisionEnter2D(collision);

        if (collision.gameObject.CompareTag("Ground"))
        {

            Destroy(gameObject);

        }
    }


}
