using UnityEngine;

public class PlayerWalkController : MonoBehaviour
{
    [SerializeField] private Rigidbody myRigidbody;
    [SerializeField] private CommandContainer commandContainer;

    [SerializeField] private WalkSpeedSO walkSpeedSo;
    // [SerializeField] private float walkSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        HandleWalking();
    }

    private void HandleWalking()
    {
        //Apply moveSpeed to rigidbody
        myRigidbody.velocity = new Vector3(commandContainer.walkCommand * walkSpeedSo.WalkSpeed, myRigidbody.velocity.y, 0);
    }
}