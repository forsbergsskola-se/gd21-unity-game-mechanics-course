using System;
using UnityEngine;

public class CommandContainer : MonoBehaviour
{
    public float walkCommand;
    public bool jumpCommand;
    public bool jumpCommandDown;
    public bool jumpCommandUp;

    public Action OnJumpCommandDown;
}