using UnityEngine;

public class PositionFollower : MonoBehaviour
{
    [SerializeField] private Transform transformToFollow;
    [SerializeField] private Vector3 positionOffset;

    private void Update()
    {
        transform.position = transformToFollow.position + positionOffset;
    }
}