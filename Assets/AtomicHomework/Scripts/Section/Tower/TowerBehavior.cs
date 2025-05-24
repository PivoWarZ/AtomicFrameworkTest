using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class TowerBehavior: IEntityInit, IEntityEnable, IEntityDispose
    {
        private IEntity _entity;
        private IEvent _onShoot;

        private float _hitPowerForDamage;
        
        void IEntityInit.Init(IEntity entity)
        {
            _entity = entity;
            _onShoot = entity.GetOnShootRequest();
            _hitPowerForDamage = entity.GetHitPowerForDamage();
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnTimerEnd().Subscribe(Shoot);
            entity.GetOnEntityCollisionEnter().Subscribe(OnCollisionEnter);
        }
        
        private void OnCollisionEnter(Collision collision)
        {
            var damage = collision.relativeVelocity.magnitude;
            
            if (damage > _hitPowerForDamage)
            {
                _entity.GetOnTakeDamageAction().Invoke(damage);
            }
        }

        private void Shoot()
        {
            _onShoot.Invoke();
        }

        public void Dispose(IEntity entity)
        {
            entity.GetOnTimerEnd().Unsubscribe(Shoot);
            entity.GetOnEntityCollisionEnter().Unsubscribe(OnCollisionEnter);
        }
    }
}