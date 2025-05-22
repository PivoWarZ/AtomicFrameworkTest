using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualCharacterBehavior: IEntityInit, IEntityEnable, IEntityDispose

    {
        private Animator _animator;
        private Transform _playerTransform;
        private AnimationEventDispatcher _animationEventDispatcher;
        private IEvent _onShootAction;
        void IEntityInit.Init(IEntity entity)
        {
            _playerTransform = entity.GetEntityTransform();
            _animator = entity.GetAnimator();
            _onShootAction = entity.GetOnShootAction();
            _animationEventDispatcher = entity.GetAnimationEventDispatcher();
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            _animationEventDispatcher.OnEventReceived += EventReceived;
            entity.GetMoveDirection().Subscribe(Move);
            entity.GetOnShootRequest().Subscribe(ShootRequest);
            entity.GetOnShootEvent().Subscribe(ShootEvent);
        }

        private void ShootEvent()
        {
            _animator.SetBool("isTakeAim", false);
        }

        private void EventReceived(string eventName)
        {
            if (eventName == "Shoot")
            {
                _onShootAction.Invoke();
            }
        }

        private void ShootRequest()
        {
            if (!_animator.GetBool("isRun") && !_animator.GetBool("isTakeAim"))
            {
                _animator.SetBool("isTakeAim", true);
            }
            else
            {
                _onShootAction.Invoke();
            }
        }

        private void Move(Vector3 direction)
        {
            _animator.SetBool("isRun", direction != Vector3.zero);

            var inverseDirection = _playerTransform.InverseTransformDirection(direction);
            
            _animator.SetFloat("YAxis", inverseDirection.z);
            _animator.SetFloat("XAxis", inverseDirection.x);
        }
        
        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetMoveDirection().Unsubscribe(Move);
        }
    }
}