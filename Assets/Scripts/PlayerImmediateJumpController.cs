using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public GroundChecker myGroundChecker;
    public PlayerInputController playerInputController;
    public float jumpForce = 500f;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        //If we pressed the jump button: then jump
        if (playerInputController.jumpInputDown == true && myGroundChecker.isGrounded == true)
        {
            // Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
}