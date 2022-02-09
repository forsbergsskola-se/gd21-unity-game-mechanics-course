using UnityEngine;

public class PlayerImmediateJumpController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private GroundChecker myGroundChecker;
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private float jumpForce = 500f;

    //--- EVENT VERSION ---
    private void OnEnable()
    {
        commandContainer.OnJumpCommandDown += HandleJumpThroughEvent; //Subscribe to the event.
    }

    private void OnDisable()
    {
        commandContainer.OnJumpCommandDown -= HandleJumpThroughEvent; //Unsubscribe from the event.
    }

    //This method gets called through the event OnJumpCommandDown in CommandContainer.
    private void HandleJumpThroughEvent()
    {
        //If we are grounded: jump.
        if (myGroundChecker.IsGrounded == true)
        {
            // Debug.Log("Jump");
            myRigidbody.AddForce(0, jumpForce, 0);
        }
    }
    //--- END EVENT VERSION ---

    //--- POLLING VERSION ---
    // // Update is called once per frame
    // void Update()
    // {
    //     HandleJump();
    // }

    // private void HandleJump()
    // {
    //     //If we pressed the jump button AND are grounded: then jump
    //     if (commandContainer.jumpCommandDown == true && myGroundChecker.IsGrounded == true)
    //     {
    //         // Debug.Log("Jump");
    //         myRigidbody.AddForce(0, jumpForce, 0);
    //     }
    // }
    //--- END POLLING VERSION ---
}