using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    public Rigidbody myRigidbody;
    public PlayerInputController playerInputController;
    public float walkSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }

    private void HandleWalking()
    {
        //Apply moveSpeed to rigidbody
        myRigidbody.velocity = new Vector3(playerInputController.walkInput * walkSpeed, myRigidbody.velocity.y, 0);
    }
}