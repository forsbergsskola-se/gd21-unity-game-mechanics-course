using UnityEngine;

public class UnityEventExecutionOrderExample : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Start");
    }

    private void Awake()
    {
        Debug.Log("Awake");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable");
    }
}