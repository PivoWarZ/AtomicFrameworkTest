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
            var directionAngle = Vector3.Angle(_playerTransform.forward, direction);
            bool isRightSide = _playerTransform.rotation.y > 0f;
            bool isLeftSide = _playerTransform.rotation.y < 0f;
            
            if (direction == Vector3.zero)
            {
               _animator.SetBool("RunForward", false);
               _animator.SetBool("RunBack", false);
               _animator.SetBool("SideStepRight", false);
               _animator.SetBool("SideStepLeft", false);
            }
            else if (directionAngle < 45)
            {
                _animator.SetBool("RunForward", true);
            }
            else if (directionAngle > 45 && directionAngle < 110)
            {
                if (direction == Vector3.right 
                    || direction == Vector3.forward && isLeftSide 
                    || direction == Vector3.back && isRightSide)
                {
                    _animator.SetBool("SideStepRight", true);
                }
                else if (direction == Vector3.left 
                         || direction == Vector3.back && isLeftSide
                         || direction == Vector3.forward && isRightSide)
                {
                    _animator.SetBool("SideStepLeft", true);
                }
            }
            else if (directionAngle > 110 && directionAngle <= 180)
            {
                _animator.SetBool("RunBack", true);
            }
        }
        
        void IEntityDispose.Dispose(IEntity entity)
        {
            
        }
    }
}