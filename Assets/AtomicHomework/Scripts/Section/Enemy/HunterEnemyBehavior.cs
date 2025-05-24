using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class HunterEnemyBehavior: IEntityInit, IEntityDispose, IEntityUpdate, IEntityEnable
    {
        private Transform _enemyTransform;
        private float _damage;
        private IEntity _target;
        
        void IEntityInit.Init(IEntity entity)
        {
            _target = entity.GetLoockAtTransform().gameObject.GetComponent<IEntity>();
            _enemyTransform = entity.GetEntityTransform();
            _damage = entity.GetDamage();
        }

        public void Enable(IEntity entity)
        {
            entity.GetDealTickDamage().Subscribe(DealDamage);
        }
        
        private void DealDamage()
        {
            _target.GetOnTakeDamageAction().Invoke(_damage);
        }
        
        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            if (entity.GetCanMove().Value)
            {
                entity.GetMoveDirection().Value = _enemyTransform.forward;
            }
        }
        
        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetDealTickDamage().Unsubscribe(DealDamage);
        }

    }
}