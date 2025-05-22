using System;
using Atomic.Contexts;
using Atomic.Entities;

using UnityEngine;

namespace ZombieShooter
{
    [Serializable]
    public class PlayerMoveBehavior: IContextInit, IContextDispose, IContextEnable
    {
        SceneEntity _sceneEntity;
        private MoveInput _moveInput;
        
        public void Init(IContext context)
        {
            _sceneEntity = context.GetServiceLocator().Player;
            _moveInput = context.GetMoveInput();
        }
        
        void IContextEnable.Enable(IContext context)
        {
            _moveInput.MoveDirection.Subscribe(Move);
        }

        private void Move(Vector3 direction)
        {
            _sceneEntity.GetMoveDirection().Value = direction;
        }

        void IContextDispose.Dispose(IContext context)
        {
            _moveInput.MoveDirection.Unsubscribe(Move);
        }
    }
}