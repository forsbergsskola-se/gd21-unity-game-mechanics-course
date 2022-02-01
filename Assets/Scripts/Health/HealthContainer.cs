using UnityEngine;

public class HealthContainer : MonoBehaviour
{
    [SerializeField] private float maxHealth = 3f;

    private float currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
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
        currentHealth -= damage;
        CheckHealth();
    }

    public void InstantKill()
    {
        Die(); //You could also make Die() public and call that directly.
    }

    private void CheckHealth()
    {
        if (currentHealth <= 0)
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