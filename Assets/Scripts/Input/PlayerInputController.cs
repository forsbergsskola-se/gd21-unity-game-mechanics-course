using UnityEngine;

public class PlayerInputController : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;

    public float WalkInput { get; private set; }
    public bool JumpInput { get; private set; }
    public bool JumpInputDown { get; private set; }
    public bool JumpInputUp { get; private set; }

    private void Update()
    {
        GetInput();
        SetCommands();
    }

    private void GetInput()
    {
        WalkInput = Input.GetAxis("Horizontal");

        JumpInput = Input.GetKey(KeyCode.Space);
        JumpInputDown = Input.GetKeyDown(KeyCode.Space);
        JumpInputUp = Input.GetKeyUp(KeyCode.Space);
    }

    private void SetCommands()
    {
        commandContainer.walkCommand = WalkInput;
        commandContainer.jumpCommand = JumpInput;
        commandContainer.jumpCommandDown = JumpInputDown;
        commandContainer.jumpCommandUp = JumpInputUp;
    }
}