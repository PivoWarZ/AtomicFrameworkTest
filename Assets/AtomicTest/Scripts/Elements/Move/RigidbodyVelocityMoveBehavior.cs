using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class RigidbodyVelocityMoveBehavior: IEntityFixedUpdate, IEntityInit

    {
        private Rigidbody _rigidbody;

        void IEntityFixedUpdate.OnFixedUpdate(IEntity entity, float deltaTime)
        {
            var canMove = entity.GetCanMove();

            if (canMove.Value)
            {
                var moveTransform = entity.GetEntityTransform();
                var moveSpeed = entity.GetMoveSpeed();
                var moveDirection = entity.GetMoveDirection();

                _rigidbody.linearVelocity = moveDirection.Value * moveSpeed.Value;
            }
        }

        public void Init(IEntity entity)
        {
            _rigidbody = entity.GetEntityTransform().GetComponent<Rigidbody>();
        }
    }
}