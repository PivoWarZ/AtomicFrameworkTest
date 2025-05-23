using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class BulletBehavior: IEntityInit, IEntityDispose
    {
        private float _damage;
        private Transform _bulletTransform;
        
        public void Init(IEntity entity)
        {
            _damage = entity.GetDamage();
            _bulletTransform = entity.GetEntityTransform();
            entity.GetOnEntityTriggerEnter().Subscribe(OnTriggerEnter);
        }

        private void OnTriggerEnter(IEntity other)
        {
            
            if (other.TryGetOnHit(out var onHit))
            {
                onHit.Invoke(_damage);
                SceneEntity.Destroy(_bulletTransform.gameObject);
            }

        }
        
        public void Dispose(IEntity entity)
        {
            entity.GetOnEntityTriggerEnter().Unsubscribe(OnTriggerEnter);
        }
    }
}
