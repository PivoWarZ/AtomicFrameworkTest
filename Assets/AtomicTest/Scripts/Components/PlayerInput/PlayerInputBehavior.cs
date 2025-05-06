using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class PlayerInputBehavior : IEntityInit, IEntityUpdate
    {
        private SceneEntity _sceneEntity;
        private KeyCode _forwardInput;
        private KeyCode _leftInput;
        private KeyCode _rightInput;
        private KeyCode _downInput;

        public void Init(IEntity entity)
        {
            _sceneEntity = entity.GetMovableEntity();
            _forwardInput = entity.GetForwardDirectionInput();
            _leftInput = entity.GetLeftDirectionInput();
            _rightInput = entity.GetRightDirectionInput();
            _downInput = entity.GetDownDirectionInput();
        }

        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            _sceneEntity.GetMoveDirection().Value = Vector3.zero;

            if (Input.GetKey(_forwardInput))
            {
                _sceneEntity.GetMoveDirection().Value = Vector3.forward;
            }
            else if (Input.GetKey(_rightInput))
            {
                _sceneEntity.GetMoveDirection().Value = Vector3.right;
            }
            else if (Input.GetKey(_downInput))
            {
                _sceneEntity.GetMoveDirection().Value = -Vector3.forward;
            }
            else if (Input.GetKey(_leftInput))
            {
                _sceneEntity.GetMoveDirection().Value = Vector3.left;
            }
        }
    }
}
