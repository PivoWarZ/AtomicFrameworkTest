using System;
using Atomic.Contexts;
using Atomic.Entities;

using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class PlayerInputController: IContextInit
    {
        [SerializeField] SceneEntity _sceneEntity;
        private MoveInput _moveInput;


        public void Init(IContext context)
        {
            _moveInput = context.GetPlayerInput();
            _moveInput.Move.Subscribe(Move);
        }

        private void Move(Vector3 direction)
        {
            _sceneEntity.GetMoveDirection().Value = direction;
            _sceneEntity.GetRotateDirection().Value = direction;
        }
    }
}