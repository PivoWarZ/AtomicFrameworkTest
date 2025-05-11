using Atomic.Entities;
using Atomic.Elements;
using UnityEngine;

namespace testAtomic
{
    public class CharacterActionBehavior: IEntityUpdate, IEntityInit
    
    {
        private ReactiveVariable<bool> _notEnemy= new();
        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            Ray ray = new Ray(entity.GetEntityTransform().position, entity.GetEntityTransform().forward);
            
            Debug.DrawRay(entity.GetEntityTransform().position, entity.GetEntityTransform().forward * 2, Color.yellow);
            
            if (Physics.Raycast(ray, out RaycastHit hit, 2f, 6 << LayerMask.NameToLayer("Enemy")))
            {
                Debug.Log(hit.collider.name);
                _notEnemy.Value = false;
                
                if (Input.GetMouseButton(0))
                {
                    hit.rigidbody.AddForce(hit.normal * 100f, ForceMode.Impulse);
                }
            }
        }

        public void Init(IEntity entity)
        {
            _notEnemy = true;
            entity.GetCanShoot().Append(_notEnemy);
        }
    }
}