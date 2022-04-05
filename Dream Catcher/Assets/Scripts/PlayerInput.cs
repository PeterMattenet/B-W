using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    Movement playerMovement;

    bool jumpInput;
    bool mouseInput;
    float moveInput;

    private void Start()
    {

        playerMovement = GetComponent<Movement>();

    }

    private void Update()
    {

        CollectInput();

    }

    private void FixedUpdate()
    {
        //Apply movement based on input 
        playerMovement.Move(Vector2.right * moveInput);
        //Jump if we press the jump input
        if (jumpInput) { playerMovement.Jump(); }
    }

    //Gathers all the input the player has and updates corresponding variables
    void CollectInput()
    {

        jumpInput = Input.GetButton("Jump");
        mouseInput = Input.GetMouseButtonDown(0);
        moveInput = Input.GetAxisRaw("Horizontal");

    }

}
