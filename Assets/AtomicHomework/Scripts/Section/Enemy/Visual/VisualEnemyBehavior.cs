using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualEnemyBehavior: IEntityInit, IEntityEnable, IEntityDispose
    {
        private IEntity _target;
        private Animator _animator;
        private IEntity _entity;
        
        public void Init(IEntity entity)
        {
            _animator = entity.GetAnimator();
            _entity = entity;
            _target = entity.GetLoockAtTransform().gameObject.GetComponent<IEntity>();
        }
        
        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetAnimationEventDispatcher().OnEventReceived += EventReceived;
            entity.GetOnHitPointsEmpty().Subscribe(DeathAnimation);
            entity.GetIsAttackDistance().Subscribe(AttackDistance);
            entity.GetDealTickDamage().Subscribe(DealDamage);
            entity.GetOnTakeDamageEvent().Subscribe(DamageEvent);
            _target.GetOnDeathEvent().Subscribe(StopAnimation);
        }

        private void StopAnimation()
        {
            _animator.SetLayerWeight(1, 0);
        }

        private void EventReceived(string eventName)
        {
            if (eventName == "Death")
            {
                _entity.GetOnDeathAction().Invoke();
            }
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

        private void DeathAnimation()
        {
            StopAnimation();
            _entity.GetParticlesContainer().TakeDamageParticle.Play();
            _animator.SetTrigger("Death");
        }

        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetAnimationEventDispatcher().OnEventReceived -= EventReceived;
            entity.GetOnHitPointsEmpty().Unsubscribe(DeathAnimation);
            entity.GetIsAttackDistance().Unsubscribe(AttackDistance);
            entity.GetDealTickDamage().Unsubscribe(DealDamage);
            entity.GetOnTakeDamageEvent().Unsubscribe(DamageEvent);
            _target.GetOnDeathEvent().Subscribe(StopAnimation);
        }
    }
}