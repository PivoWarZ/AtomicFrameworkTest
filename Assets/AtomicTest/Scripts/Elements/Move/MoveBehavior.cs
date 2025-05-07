using Atomic.Entities;

namespace testAtomic
{
    public class MoveBehavior : IEntityFixedUpdate
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
