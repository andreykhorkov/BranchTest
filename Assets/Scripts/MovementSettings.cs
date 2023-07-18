using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "PlayerMovementSettings", menuName = "ScriptableObjects/MovementSettings", order = 1)]
    public class MovementSettings : ScriptableObject
    {
        public float Speed;
        public float RotationSpeed;
    }
}