using UnityEngine;

[CreateAssetMenu(menuName = "Our Scriptable Objects/Death Counter")]
public class DeathCounterSO : ScriptableObject
{
    public int numberOfDeaths;

    //This is called everytime we start the game, even if we're in a scene where nothing uses this ScriptableObject. Also happens on scene change.
    //It's usually a better idea to reset your ScriptableObject data through a MonoBehaviour, as it's often easier to predict when those callbacks happen.
    // private void OnEnable()
    // {
    //     Debug.Log("Reset deaths.");
    //     numberOfDeaths = 0;
    // }
}