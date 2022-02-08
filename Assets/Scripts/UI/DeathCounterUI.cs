using TMPro;
using UnityEngine;

public class DeathCounterUI : MonoBehaviour
{
    [SerializeField] private DeathCounterSO deathCounterSo;
    [SerializeField] private TextMeshProUGUI deathCounterText;

    private void Update()
    {
        // deathCounterText.text = "Deaths: " + deathCounterSo.numberOfDeaths;
        deathCounterText.text = $"Deaths: {deathCounterSo.numberOfDeaths}"; //Gives the same result as above.
    }
}