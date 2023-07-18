using UnityEngine;

namespace DefaultNamespace
{
    public class KeyboardMovementSystem : IInputSystem
    {
        Vector2 IInputSystem.GetInput()
        {
            var horizontal = Input.GetAxis("Horizontal");
            var vertical = Input.GetAxis("Vertical");

            return new Vector2(horizontal, vertical);
        }
    }
}