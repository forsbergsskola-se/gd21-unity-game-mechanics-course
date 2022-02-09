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
        CallEvents();
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

    private void CallEvents()
    {
        //We only want to Invoke OnJumpCommandDown if something is subscribed to it, i.e. if it's NOT null.

        //Null check through if statement.
        // if (JumpInputDown && commandContainer.OnJumpCommandDown != null)
        //     commandContainer.OnJumpCommandDown.Invoke(); //Emits a signal from the event to everyone listening to the event.

        //Null check through null propagating operator. Achieves the same result as the if statement above.
        if (JumpInputDown)
            commandContainer.OnJumpCommandDown?.Invoke(); //Emits a signal from the event to everyone listening to the event.
    }
}