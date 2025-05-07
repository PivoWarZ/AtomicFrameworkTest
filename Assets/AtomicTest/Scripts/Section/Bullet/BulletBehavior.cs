using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class BulletBehavior: IEntityInit, IEntityDispose
    {
        private float _damage;
        
        public void Init(IEntity entity)
        {
            _damage = entity.GetBulletDamage();
            entity.GetOnEntityTriggerEnter().Subscribe(OnTriggerEnter);
        }

        private void OnTriggerEnter(IEntity other)
        {
            Debug.Log("Bullet OnTriggerEnter");

            if (other.TryGetOnHit(out var onHit))
            {
                onHit.Invoke(_damage);
            }
        }

        public void Dispose(IEntity entity)
        {
            entity.GetOnEntityTriggerEnter().Unsubscribe(OnTriggerEnter);
        }
    }
}
