using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class VisualCharacterBehavior: IEntityInit, IEntityEnable, IEntityUpdate, IEntityDispose

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
        }


        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            
        }

        private void Move(Vector3 direction)
        {
            if (direction == Vector3.zero)
            {
                _animator.SetFloat("YAxis", 0);
                _animator.SetFloat("XAxis", 0);
            }
            
            var inverseDirection = _playerTransform.InverseTransformDirection(direction);
            Debug.Log(inverseDirection);
            
            _animator.SetFloat("YAxis", inverseDirection.z);
            _animator.SetFloat("XAxis", inverseDirection.x);
        }
        
        void IEntityDispose.Dispose(IEntity entity)
        {
            
        }
    }
}