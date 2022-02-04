using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    [SerializeField] private float maxHealth = 3f;

    public float CurrentHealth { get; private set; } //This doesn't show up in the inspector.
    public float MaxHealth => maxHealth; //Creates a getter property that returns the value of maxHealth.

    private void Start()
    {
        CurrentHealth = maxHealth;
    }

    // private void OnEnable()
    // {
    //     //This method runs when a GameObject is activated (enabled).
    // }
    //
    // private void OnDisable()
    // {
    //     //This method runs when a GameObject is deactivated (disabled).
    // }

    public void DealDamage(float damage)
    {
        CurrentHealth -= damage;
        CheckHealth();
    }

    public void InstantKill()
    {
        Die(); //You could also make Die() public and call that directly.
    }

    private void CheckHealth()
    {
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
        // gameObject.SetActive(false); //This disables the gameObject
    }
}