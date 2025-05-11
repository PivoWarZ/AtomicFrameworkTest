using System;
using Atomic.Contexts;
using Atomic.Entities;

using UnityEngine;

namespace testAtomic
{
    [Serializable]
    public class TransformPositionInputController: IContextInit, IContextDispose
    {
        [SerializeField] SceneEntity _sceneEntity;
        private MoveInput _moveInput;


        public void Init(IContext context)
        {
            _moveInput = context.GetPlayerInput();
            _moveInput.OnStay.Subscribe(OnStay);
            _moveInput.OnForward.Subscribe(MoveForward);
            _moveInput.OnRight.Subscribe(MoveRight);
            _moveInput.OnLeft.Subscribe(MoveLeft);
            _moveInput.OnBack.Subscribe(MoveBack);
        }

        private void MoveBack()
        {
            _sceneEntity.GetMoveDirection().Value = -_sceneEntity.GetEntityTransform().forward;
        }

        private void MoveLeft()
        {
            _sceneEntity.GetMoveDirection().Value = -_sceneEntity.GetEntityTransform().right;
        }

        private void MoveRight()
        {
            _sceneEntity.GetMoveDirection().Value = _sceneEntity.GetEntityTransform().right;
        }

        private void OnStay()
        {
            _sceneEntity.GetMoveDirection().Value = Vector3.zero;
        }

        private void MoveForward()
        {
            _sceneEntity.GetMoveDirection().Value = _sceneEntity.GetEntityTransform().forward;
        }


        public void Dispose(IContext context)
        {
            _moveInput.OnStay.Unsubscribe(OnStay);
            _moveInput.OnForward.Unsubscribe(MoveForward);
            _moveInput.OnRight.Unsubscribe(MoveRight);
            _moveInput.OnLeft.Unsubscribe(MoveLeft);
            _moveInput.OnBack.Unsubscribe(MoveBack);
        }
    }
}