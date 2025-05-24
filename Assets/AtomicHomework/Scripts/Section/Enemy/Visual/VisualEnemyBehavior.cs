using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualEnemyBehavior: IEntityInit, IEntityEnable, IEntityDispose
    {
        private Animator _animator;
        private IEntity _entity;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _entity = entity;
        }
        
        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnHitPointsEmpty().Subscribe(DeathEvent);
            entity.GetIsAttackDistance().Subscribe(AttackDistance);
            entity.GetDealTickDamage().Subscribe(DealDamage);
            entity.GetOnTakeDamageEvent().Subscribe(DamageEvent);
        }

        private void DamageEvent()
        {
            _entity.GetParticlesContainer().TakeDamageParticle.Play();
        }

        private void DealDamage()
        {
            _animator.SetTrigger("DealDamage");
        }

        private void AttackDistance(bool shoot)
        {
            _animator.SetBool("isAttackDistance", shoot);
        }

        private void DeathEvent()
        {
            _animator.SetTrigger("Death");
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnHitPointsEmpty().Unsubscribe(DeathEvent);
        }
    }
}