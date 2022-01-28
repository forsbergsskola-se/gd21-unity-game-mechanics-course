using UnityEngine;

public class MoveTowardsPlayerAI : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;
    [SerializeField] private Transform playerTransform;

    private void Update()
    {
        //To get a direction vector to a target: {Target_Position} - {Origin_Position}
        var directionToPlayer = playerTransform.position - transform.position;

        //Normalize direction vector (makes sure length of vector is exactly 1).
        // If we don't do this, the enemy will move super fast when far away from the player, because the direction vector also scales the moveSpeed through the commands.
        directionToPlayer.Normalize();

        //Get the horizontal part of our direction.
        var horizontalDirection = directionToPlayer.x;

        //Pass along direction to command container.
        commandContainer.walkCommand = horizontalDirection;
    }
}