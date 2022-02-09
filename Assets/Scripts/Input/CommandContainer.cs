using System;
using UnityEngine;

public class CommandContainer : MonoBehaviour
{
    public float walkCommand;
    public bool jumpCommand;
    public bool jumpCommandDown;
    public bool jumpCommandUp;

    public Action OnJumpCommandDown;

    //This method is only intended to force-invoke OnJumpCommandDown through UnityEvents. See example with enemies jump when the player dies.
    public void InvokeJumpCommandDown() => OnJumpCommandDown?.Invoke();
}