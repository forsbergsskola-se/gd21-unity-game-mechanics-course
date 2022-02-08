using UnityEngine;

public class MonoBehaviourEventCallbackExamples : MonoBehaviour
{
    private void Start() => Debug.Log("Start");

    private void Awake() => Debug.Log("Awake");

    private void OnEnable() => Debug.Log("OnEnable");

    private void OnDisable() => Debug.Log("OnDisable");

    private void OnDestroy() => Debug.Log("OnDestroy");

    private void Update() => Debug.Log("Update");

    private void FixedUpdate() => Debug.Log("FixedUpdate");

    private void LateUpdate() => Debug.Log("LateUpdate");
}