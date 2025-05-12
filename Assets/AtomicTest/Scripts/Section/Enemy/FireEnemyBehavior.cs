using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class FireEnemyBehavior: IEntityInit, IEntityDispose, IEntityUpdate
    {
        private Transform _enemyTransform;
        private float _damage;
        
        void IEntityInit.Init(IEntity entity)
        {
            _enemyTransform = entity.GetEntityTransform();
            _damage = entity.GetDamage();
            entity.GetOnEntityTriggerEnter().Subscribe(OnTriggerEnter);
            entity.GetOnEntityCollisionEnter().Subscribe(OnEntityCollisionEnter);
        }

        private void OnTriggerEnter(IEntity other)
        {
            if (other.TryGetOnHit(out var onHit))
            {
                onHit.Invoke(_damage);
                SceneEntity.Destroy(_enemyTransform.gameObject);
            }
        }

        private void OnEntityCollisionEnter(Collision collision)
        {
            if (collision.relativeVelocity.magnitude > 20)
            {
                SceneEntity.Destroy(_enemyTransform.gameObject);
            }

        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnEntityTriggerEnter().Unsubscribe(OnTriggerEnter);
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            entity.GetMoveDirection().Value = _enemyTransform.forward;
        }
    }
}