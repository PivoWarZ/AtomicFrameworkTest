using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class TransformPositionMoveBehavior : IEntityFixedUpdate
    {
        void IEntityFixedUpdate.OnFixedUpdate(IEntity entity, float deltaTime)
        {
            var canMove = entity.GetCanMove();
            
            if (canMove.Value)
            {
                var moveTransform = entity.GetEntityTransform();
                var moveSpeed = entity.GetMoveSpeed();
                var moveDirection = entity.GetMoveDirection();
                
                moveTransform.position += moveDirection.Value * moveSpeed.Value * deltaTime;
            }
        }
    }
}
