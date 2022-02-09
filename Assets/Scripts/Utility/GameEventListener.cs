using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] private GameEventSO gameEventSo; //The ScriptableObject that we're listening to.
    [SerializeField] private UnityEvent onGameEvent; //The UnityEvent that we hook up whatever we want to. The things we hook up will run when we get a signal from the GameEventSO.

    private void OnEnable() => gameEventSo.OnGameEvent += OnGameEventSignal; //Subscribe to GameEventSO.
    private void OnDisable() => gameEventSo.OnGameEvent -= OnGameEventSignal; //Unsubscribe from GameEventSO.

    private void OnGameEventSignal() => onGameEvent.Invoke(); //Invoke our UnityEvent when we get a signal from the GameEventSO.
}