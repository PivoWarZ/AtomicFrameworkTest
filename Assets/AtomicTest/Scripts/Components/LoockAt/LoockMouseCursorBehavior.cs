using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class LoockMouseCursorBehavior: IEntityUpdate, IEntityFixedUpdate, IEntityInit
    {
        private Vector3 _mousePosition;
        private Ray _ray;
        private RaycastHit _hit;
        private Vector3 _position;
        
        public void Init(IEntity entity)
        {
            Cursor.lockState = CursorLockMode.Confined;
            Cursor.visible = false;
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            _mousePosition = Input.mousePosition;
            _mousePosition.z = Camera.main.nearClipPlane;
            _ray = Camera.main.ScreenPointToRay(_mousePosition);
            
            if (Physics.Raycast(_ray, out RaycastHit hit, Mathf.Infinity, 3 << LayerMask.NameToLayer("Ground")))
            {
                _hit = hit;
            }
        }

        void IEntityFixedUpdate.OnFixedUpdate(IEntity entity, float deltaTime)
        {
            entity.GetRotateDirection().Value = _hit.point;
        }

    }
}