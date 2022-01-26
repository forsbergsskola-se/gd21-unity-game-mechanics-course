using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public float walkSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }

    private void HandleWalking()
    {
        //Get move input
        var moveInput = Input.GetAxis("Horizontal");
        //Print move input in the console
        //Debug.Log("Our move input:" + moveInput);

        //Apply moveSpeed to rigidbody
        myRigidbody.velocity = new Vector3(moveInput * walkSpeed, myRigidbody.velocity.y, 0);
    }
}