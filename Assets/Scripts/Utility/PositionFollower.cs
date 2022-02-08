using UnityEngine;

public class PositionFollower : MonoBehaviour
{
    [SerializeField] private Transform transformToFollow;
    [SerializeField] private Vector3 positionOffset;

    private void Update()
    {
        //Only follow if we have a transformToFollow.
        //WARNING! If we forget to assign a transformToFollow, we won't get any errors/warnings telling us about it. Be careful!
        if (transformToFollow != null)
            transform.position = transformToFollow.position + positionOffset;
    }
}