using UnityEngine;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private HealthContainer healthContainer;
    [SerializeField] private RectTransform healthBarRectTransform;

    private void Update()
    {
        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        if (healthContainer == null)
        {
            // Debug.Log("No HealthContainer found");
            healthBarRectTransform.localScale = new Vector3(0, healthBarRectTransform.localScale.y, healthBarRectTransform.localScale.z);
            return;
        }

        //This part only runs if there is a HealthContainer found (thanks to the early return above).
        var healthFraction = healthContainer.CurrentHealth / healthContainer.MaxHealth; //Gets out current health in the range 0-1
        healthBarRectTransform.localScale = new Vector3(healthFraction, healthBarRectTransform.localScale.y, healthBarRectTransform.localScale.z);
    }
}