using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private GroundChecker myGroundChecker;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private float jumpForce = 500f;

    // Update is called once per frame
    void Update()
    {
        HandleJump();
    }

    private void HandleJump()
    {
        //If we pressed the jump button: then jump
        if (commandContainer.jumpCommandDown == true && myGroundChecker.IsGrounded == true)
        {
            // Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
}