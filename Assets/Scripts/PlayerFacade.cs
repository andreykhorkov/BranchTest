using System;
using DefaultNamespace;
using UnityEngine;

public class PlayerFacade : MonoBehaviour
{
    [SerializeField] private PlayerSettings _settings;
    
    private IMovementSystem _movementSystem;

    public static event Action<PlayerFacade> PlayerClicked = delegate {  };

    private void Start()
    {
        _movementSystem = new GroundMovementSystem(transform);
    }

    public void Move(Vector2 input, float dt)
    {
        _movementSystem.Move(input, _settings, dt);
    }

    private void OnMouseDown()
    {
        PlayerClicked.Invoke(this);
    }
}
