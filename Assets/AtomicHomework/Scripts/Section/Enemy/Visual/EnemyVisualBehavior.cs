using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class EnemyVisualBehavior: IEntityInit, IEntityEnable, IEntityDispose
    {
        private IEntity _sceneEntity;
        private Animator _animator;
        private Transform _sceneEntityTransform;
        private AnimationEventDispatcher _animationEventDispatcher;
        private IEvent _onShootAction;
        
        public void Init(IEntity entity)
        {
            _sceneEntity = entity;
            _sceneEntityTransform = entity.GetEntityTransform();
            _animator = entity.GetAnimator();
            _onShootAction = entity.GetOnShootAction();
            _animationEventDispatcher = entity.GetAnimationEventDispatcher();
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnHitPointsEmpty().Subscribe(DeathEvent);
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