using UnityEngine;

namespace DefaultNamespace
{
    public class GroundMovementSystem : IMovementSystem
    {
        public MovementSettings Settings { get; }
        public Transform Tf { get; }

        public GroundMovementSystem(Transform playerTf, MovementSettings settings)
        {
            Tf = playerTf;
            Settings = settings;
        }
        
        void IMovementSystem.Move(Vector2 input, float dt)
        {
            Tf.position += Tf.forward * (input.y * dt * Settings.Speed);
            Tf.rotation *= Quaternion.AngleAxis(input.x * Settings.RotationSpeed * dt, Vector3.up);
        }
    }
}