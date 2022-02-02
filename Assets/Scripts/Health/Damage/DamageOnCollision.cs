using UnityEngine;

public class DamageOnCollision : MonoBehaviour
{
    [SerializeField] private float damage = 1f;

    //Example of damage on collision.
    //Called only the one frame that two colliders/rigidbodies start being in contact.
    // private void OnCollisionEnter(Collision other)
    // {
    //     //"other" contains data about our collision.
    //     //Get the GameObject that we collided with.
    //     var collidedGameObject = other.gameObject;
    //
    //     //Look for HealthContainer on the GameObject we collided with, using GetComponent.
    //     var healthContainerOnCollidedGameObject = collidedGameObject.GetComponent<HealthContainer>();
    //
    //     //Make sure that a HealthContainer component was found before dealing damage.
    //     if (healthContainerOnCollidedGameObject != null)
    //     {
    //         healthContainerOnCollidedGameObject.DealDamage(damage);
    //         // healthContainerOnCollidedGameObject.InstantKill();
    //     }
    // }

    // Example of damage over time on continuous collision.
    // Called every frame that two colliders/rigidbodies are in contact.
    private void OnCollisionStay(Collision other)
    {
        //"other" contains data about our collision.
        //Get the GameObject that we collided with.
        var collidedGameObject = other.gameObject;

        //Look for HealthContainer on the GameObject we collided with, using GetComponent.
        var healthContainerOnCollidedGameObject = collidedGameObject.GetComponent<HealthContainer>();

        //Make sure that a HealthContainer component was found before dealing damage.
        if (healthContainerOnCollidedGameObject != null)
        {
            healthContainerOnCollidedGameObject.DealDamage(damage * Time.deltaTime); //Deal damage over time.
        }
    }
}