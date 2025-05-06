using Atomic.Entities;

namespace testAtomic
{
    public class MoveBehavior : IEntityLateUpdate
    {
        void IEntityLateUpdate.OnLateUpdate(IEntity entity, float deltaTime)
        {
            var moveTransform = entity.GetEntityTransform();
            var moveSpeed = entity.GetMoveSpeed();
            var moveDirection = entity.GetMoveDirection();

            moveTransform.position += moveDirection.Value * moveSpeed.Value * deltaTime;
        }
    }
}
