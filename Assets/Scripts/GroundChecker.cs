using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    public float groundCheckDistance = 0.6f;
    public float groundCheckSphereRadius = 0.45f;
    public bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        CheckIfGrounded();
    }

    private void CheckIfGrounded()
    {
        //Check if we're grounded, using a raycast.
        //Vector3.down: down in world space.
        //-transform.up: down in the GameObject's local space.
        // var isGrounded = Physics.Raycast(transform.position, Vector3.down, groundCheckDistance);

        //Ground checking using sphere cast. Think of it as a sphere being moved along a ray, we hit anything that the sphere touches.
        var sphereCastRay = new Ray(transform.position, Vector3.down);
        isGrounded = Physics.SphereCast(sphereCastRay, groundCheckSphereRadius, groundCheckDistance);

        //Draw a ray in the editor, only for visualization.
        // Debug.DrawRay(transform.position, Vector3.down * groundCheckDistance, Color.cyan);
    }
}