using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private GroundChecker myGroundChecker;
    [SerializeField] private PlayerInputController playerInputController;
    [SerializeField] private float jumpForce = 500f;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        //If we pressed the jump button: then jump
        if (playerInputController.JumpInputDown == true && myGroundChecker.IsGrounded == true)
        {
            // Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
}