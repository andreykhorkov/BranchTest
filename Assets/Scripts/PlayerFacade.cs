using System;
using DefaultNamespace;
using UnityEngine;

public class PlayerFacade : MonoBehaviour
{
    [SerializeField] private MovementSettings _settings;
    
    private IMovementSystem _movementSystem;

    public static event Action<IMovementSystem> PlayerClicked = delegate {  };

    private void Start()
    {
        _movementSystem = new GroundMovementSystem(transform, _settings);
    }

    private void OnMouseDown()
    {
        PlayerClicked.Invoke(_movementSystem);
    }
}
