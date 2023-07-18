using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class CameraController : MonoBehaviour
    {
        [SerializeField] private Vector3 _offset;
        [SerializeField] private Vector3 _lookAtOffset;
        [SerializeField] private float _dumpingTime = 0.5f;

        private Transform _masterTf;
        private Vector3 _camVelocity; //
        private Vector3 _camDesiredPos;

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
            _masterTf = player.transform;
        }

        private void Update()
        {
            if (ReferenceEquals(_masterTf, null))
            {
                return;
            }

            var forward = _masterTf.forward;
            var projXY = Vector3.ProjectOnPlane(forward, Vector3.up).normalized;
            var position = _masterTf.position;
            var desiredPosition = position + _offset.z * projXY + Vector3.up * _offset.y;
            _camDesiredPos = desiredPosition;
            transform.position = Vector3.SmoothDamp(transform.position, desiredPosition, ref _camVelocity, _dumpingTime);
            transform.LookAt(position + _masterTf.TransformDirection(_lookAtOffset), Vector3.up);
        }

        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;
            Gizmos.DrawSphere(_camDesiredPos, 0.5f);
        }
    }
}