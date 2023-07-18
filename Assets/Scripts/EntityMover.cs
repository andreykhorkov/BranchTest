using UnityEngine;

namespace DefaultNamespace
{
    public class EntityMover : MonoBehaviour
    {
        private IMovementSystem _movableEntity;
        private IInputSystem _inputSystem;

        private void Awake()
        {
            PlayerFacade.PlayerClicked += OnPlayerClicked;
        }

        private void OnDestroy()
        {
            PlayerFacade.PlayerClicked -= OnPlayerClicked;
        }

        private void OnPlayerClicked(IMovementSystem player)
        {
            _movableEntity = player; 
        }

        private void Start()
        {
            _inputSystem = new KeyboardMovementSystem();
        }

        private void Update()
        {
            if (ReferenceEquals(_movableEntity, null))
            {
                return;
            }
            
            _movableEntity.Move(_inputSystem.GetInput(), Time.deltaTime);
        }
    }
}