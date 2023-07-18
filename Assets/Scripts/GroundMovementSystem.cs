using UnityEngine;

namespace DefaultNamespace
{
    public class GroundMovementSystem : IMovementSystem
    {
        public Transform Tf { get; }

        public GroundMovementSystem(Transform playerTf)
        {
            Tf = playerTf;
        }
        
        void IMovementSystem.Move(Vector2 input, PlayerSettings settings, float dt)
        {
            Tf.position += Tf.forward * (input.y * dt * settings.Speed);
            Tf.rotation *= Quaternion.AngleAxis(input.x * settings.RotationSpeed * dt, Vector3.up);
        }
    }
}