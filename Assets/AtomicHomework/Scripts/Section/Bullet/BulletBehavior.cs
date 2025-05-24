using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
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
            
            if (other.TryGetOnTakeDamageAction(out var OnTakeDamage))
            {
                OnTakeDamage.Invoke(_damage);
                SceneEntity.Destroy(_bulletTransform.gameObject);
            }

        }
        
        public void Dispose(IEntity entity)
        {
            entity.GetOnEntityTriggerEnter().Unsubscribe(OnTriggerEnter);
        }
    }
}
