using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualCharacterBehavior: IEntityInit, IEntityEnable, IEntityDispose

    {
        private Animator _animator;
        private Transform _playerTransform;
        void IEntityInit.Init(IEntity entity)
        {
            _playerTransform = entity.GetEntityTransform();
            _animator = entity.GetAnimator();
        }

        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetMoveDirection().Subscribe(Move);
            entity.GetOnShootRequest().Subscribe(ShootRequest);
        }

        private void ShootRequest()
        {
            throw new System.NotImplementedException();
        }

        private void Move(Vector3 direction)
        {
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