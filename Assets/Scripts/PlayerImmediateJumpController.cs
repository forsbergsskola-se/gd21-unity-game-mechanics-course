using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public GroundChecker myGroundChecker;
    public float jumpForce = 500f;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        //Get jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //If we pressed the jump button: then jump
        if (jumpInput == true && myGroundChecker.isGrounded == true)
        {
            // Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
}