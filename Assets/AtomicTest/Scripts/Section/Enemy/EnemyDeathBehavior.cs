using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class EnemyDeathBehavior: IEntityInit
    {
        private IEntity _entity;
        void IEntityInit.Init(IEntity entity)
        {
            _entity = entity;
            entity.GetOnHitPointsEmpty().Subscribe(EnemyDeath);
        }

        private void EnemyDeath()
        {
            var rigidBody = _entity.GetEntityTransform().gameObject.GetComponent<Rigidbody>();
            var collider = _entity.GetEntityTransform().gameObject.GetComponent<SphereCollider>();
            collider.isTrigger = false;
            rigidBody.isKinematic = false;
            rigidBody.useGravity = true;
        }
    }
}