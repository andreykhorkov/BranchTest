using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class PlayerMover : MonoBehaviour
    {
        private PlayerFacade _player;
        
        private IInputSystem _inputSystem;

        private void Awake()
        {
            PlayerFacade.PlayerClicked += OnPlayerClicked;
        }

        private void OnDestroy()
        {
            PlayerFacade.PlayerClicked -= OnPlayerClicked;
        }

        private void OnPlayerClicked(PlayerFacade player)
        {
            _player = player; 
        }

        private void Start()
        {
            _inputSystem = new KeyboardMovementSystem();
        }

        private void Update()
        {
            if (_player == null)
            {
                return;
            }
            
            _player.Move(_inputSystem.GetInput(), Time.deltaTime);
        }
    }
}