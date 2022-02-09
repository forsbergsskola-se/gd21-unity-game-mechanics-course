using System;
using UnityEngine;

[CreateAssetMenu(menuName = "Our Scriptable Objects/Game Event")]
public class GameEventSO : ScriptableObject
{
    public Action OnGameEvent;

    public void InvokeGameEvent() => OnGameEvent?.Invoke();
}