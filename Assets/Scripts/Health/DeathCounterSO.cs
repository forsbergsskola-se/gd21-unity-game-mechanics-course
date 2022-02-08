using UnityEngine;

[CreateAssetMenu(menuName = "Our Scriptable Objects/Death Counter")]
public class DeathCounterSO : ScriptableObject
{
    public int numberOfDeaths;

    private void OnEnable()
    {
        Debug.Log("Reset deaths.");
        numberOfDeaths = 0;
    }
}