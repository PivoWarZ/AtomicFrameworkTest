using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class LoockAtBehavior : IEntityUpdate, IEntityFixedUpdate, IEntityInit
    {
        private bool _loockMouseCursor;
        private Vector3 _mousePosition;
        private Ray _ray;
        private RaycastHit _hit;
        private Vector3 _position;
        
        public void Init(IEntity entity)
        {
            _loockMouseCursor = entity.GetLoockMouseCursor();
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
        }
        
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            if (_loockMouseCursor)
            {
                _mousePosition = Input.mousePosition;
                _mousePosition.z = Camera.main.nearClipPlane;
                _ray = Camera.main.ScreenPointToRay(_mousePosition);
            
                if (Physics.Raycast(_ray, out RaycastHit hit, Mathf.Infinity, 3 << LayerMask.NameToLayer("Ground")))
                {
                    _hit = hit;
                }
            }
        }
        
        void IEntityFixedUpdate.OnFixedUpdate(IEntity entity, float deltaTime)
        {
            if (_loockMouseCursor)
            {
                entity.GetRotateDirection().Value = _hit.point;
                return;
            }
                
            var direction = entity.GetLoockAtTransform().Value.position - entity.GetEntityTransform().position;
            var distance = direction.magnitude;
            
            if (distance > entity.GetMinLoockDistance())
            {
                entity.GetRotateDirection().Value = direction.normalized;
            }
        }

    }
}
