using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float moveSpeed = 5f;
    public float jumpForce = 500f;
    public float groundCheckDistance = 1f;
    public float groundCheckSphereRadius = 0.5f;

    // Update is called once per frame
    void Update()
    {
        //We will create separate scripts for these game mechanics, but here's an example of putting the code in different methods.
        HandleMovement();
        HandleJump();
    }

    private void HandleMovement()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
        //Print move input in the console
        //Debug.Log("Our move input:" + moveInput);

        //Apply moveSpeed to rigidbody
        myRigidbody.velocity = new Vector3(moveInput * moveSpeed, myRigidbody.velocity.y, 0);
    }

    private void HandleJump()
    {
        //Get jump input
        var jumpInput = Input.GetKeyDown(KeyCode.Space);

        //Check if we're grounded, using a raycast.
        //Vector3.down: down in world space.
        //-transform.up: down in the GameObject's local space.
        // var isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);

        //Ground checking using sphere cast. Think of it as a sphere being moved along a ray, we hit anything that the sphere touches.
        var sphereCastRay = new Ray(transform.position, Vector3.down);
        var isGrounded = Physics.SphereCast(sphereCastRay, groundCheckSphereRadius, groundCheckDistance);

        //Draw a ray in the editor, only for visualization.
        // Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.cyan);

        //If we pressed the jump button: then jump
        if (jumpInput == true && isGrounded == true)
        {
            // Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }

    //Example of two methods with the same name but with different signatures.
    // private void TestMethod(int one, float two)
    // {
    // }
    //
    // private void TestMethod(int one, float two, int three)
    // {
    // }
}