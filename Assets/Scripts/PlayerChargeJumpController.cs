using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerChargeJumpController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public GroundChecker myGroundChecker;
    public float minimumJumpForce = 100f;
    public float maximumJumpForce = 1000f;
    public float jumpChargeTime = 1f;

    private float chargeProgress = 0f;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        //Get jump input
        var chargeInput = Input.GetKey(KeyCode.Space);
        if (chargeInput == true)
        {
            //Increase charge progress, dividing Time.deltaTime by jumpChargeTime let's us control how many seconds it takes to charge a full jump.
            chargeProgress += Time.deltaTime / jumpChargeTime;
            // chargeProgress = chargeProgress + Time.deltaTime / jumpChargeTime; //This does the same as using +=
        }

        //If we released the jump button: prepare to jump
        if (Input.GetKeyUp(KeyCode.Space) == true)
        {
            //Calculate jumpForce before resetting chargeProgress
            //Linear interpolation (lerp) between minimumJumpForce and maximumJumpForce. chargeProgress controls where in-between the two values we are.
            var jumpForce = Mathf.Lerp(minimumJumpForce, maximumJumpForce, chargeProgress);
            //Remember to reset chargeProgress
            chargeProgress = 0f;

            //If we are grounded: jump
            if (myGroundChecker.isGrounded == true)
            {
                myRigidbody.AddForce(0, jumpForce, 0);
            }
        }
    }
}