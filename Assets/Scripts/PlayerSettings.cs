using UnityEngine;

namespace DefaultNamespace
{
    [CreateAssetMenu(fileName = "PlayerSettings", menuName = "ScriptableObjects/PlayerSettings", order = 1)]
    public class PlayerSettings : ScriptableObject
    {
        public float Speed;
        public float RotationSpeed;
    }
}