using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    Movement playerMovement;

    bool jumpInput;
    bool mouseInput;

    private void Start()
    {

        playerMovement = GetComponent<Movement>();

    }

    private void Update()
    {

        CollectInput();

        //Apply movement based on input (Movement.Move is called constantly)
        playerMovement.Move(Vector2.right);
        //Jump if we press the jump input
        if (jumpInput){ playerMovement.Jump(); }

    }

    //Gathers all the input the player has and updates corresponding variables
    void CollectInput()
    {

        jumpInput = Input.GetButton("Jump");
        mouseInput = Input.GetMouseButtonDown(0);

    }

}
