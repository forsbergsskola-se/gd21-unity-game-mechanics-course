using UnityEngine;

[CreateAssetMenu(menuName = "Our Scriptable Objects/Death Counter")]
public class DeathCounterSO : ScriptableObject
{
    public int numberOfDeaths;

    private void OnEnable() //This is called everytime we start the game, even if we're in a scene where nothing uses this ScriptableObject.
    {
        // Debug.Log("Reset deaths.");
        numberOfDeaths = 0;
    }
}