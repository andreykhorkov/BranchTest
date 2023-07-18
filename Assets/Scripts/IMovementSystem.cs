using UnityEngine;

namespace DefaultNamespace
{
    public interface IMovementSystem
    {
        MovementSettings Settings { get; }
        Transform Tf { get; }
        void Move(Vector2 input, float dt);
    }
}