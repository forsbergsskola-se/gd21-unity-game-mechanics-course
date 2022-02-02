using UnityEngine;

public class MoveTowardsPlayerAI : MonoBehaviour
{
    [SerializeField] private CommandContainer commandContainer;

    private Transform playerTransform;

    private void Start()
    {
        //Be careful when using the different Find methods. They look through every GameObject in the scene until the find a match. This is performance intense.
        // playerTransform = GameObject.Find("Player").transform; //This searches for a GameObject called "Player". The name must match perfectly for the GameObject to be found.

        // playerTransform = GameObject.FindWithTag("Player").transform; //This searches for a GameObject with a tag called "Player". Text must match perfectly.

        // playerTransform = ((PlayerIdentifier)FindObjectOfType(typeof(PlayerIdentifier))).transform; //Looks for a GameObject with the component PlayerIdentifier.
        // playerTransform = FindObjectOfType<PlayerIdentifier>().transform; //Looks for a GameObject with the component PlayerIdentifier, but with cleaner code.

        var playerIdentifier = FindObjectOfType<PlayerIdentifier>();
        if (playerIdentifier != null) //If we found a PlayerIdentifier.
        {
            playerTransform = playerIdentifier.transform;
        }

        //A shorter way to only get the transform if the result of FindObjectOfType<PlayerIdentifier>() is NOT null.
        // playerTransform = FindObjectOfType<PlayerIdentifier>()?.transform; 
    }

    private void Update()
    {
        //If we have a reference to the playerTransform: move towards. If not: stop moving.
        if (playerTransform != null)
        {
            MoveTowardsPlayer();
        }
        else
        {
            Stop();
        }
    }

    private void MoveTowardsPlayer()
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

    private void Stop()
    {
        commandContainer.walkCommand = 0;
    }
}