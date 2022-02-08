using UnityEngine;

//SO stands for ScriptableObject.

[CreateAssetMenu(menuName = "Our Scriptable Objects/Walk Speed SO", fileName = "Unnamed Walk Speed SO")]
public class WalkSpeedSO : ScriptableObject
{
    [SerializeField] private float walkSpeed = 5f;
    public float WalkSpeed => walkSpeed; //Shorthand lambda expression for a getter.
}