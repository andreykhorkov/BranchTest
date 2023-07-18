using UnityEngine;

namespace DefaultNamespace
{
    public interface IMovementSystem
    {
        Transform Tf { get; }
        void Move(Vector2 input, PlayerSettings settings, float dt);
    }
}