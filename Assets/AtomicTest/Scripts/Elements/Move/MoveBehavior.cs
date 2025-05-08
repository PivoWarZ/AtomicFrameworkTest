using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class MoveBehavior : IEntityFixedUpdate
    {
        private float _zoneRange = 20f;
        void IEntityFixedUpdate.OnFixedUpdate(IEntity entity, float deltaTime)
        {
            var canMove = entity.GetCanMove();
            
            if (canMove.Value)
            {
                var moveTransform = entity.GetEntityTransform();
                var moveSpeed = entity.GetMoveSpeed();
                var moveDirection = entity.GetMoveDirection();
                
                moveTransform.position += moveDirection.Value * moveSpeed.Value * deltaTime;

                var position = entity.GetEntityTransform().position;

                if (EntityOutScene(position))
                {
                    SceneEntity.Destroy(entity.GetEntityTransform().gameObject);
                }
            }
        }

        private bool EntityOutScene(Vector3 position)
        {
            var posX = Mathf.Abs(position.x);
            var posY = Mathf.Abs(position.y);
            var posZ = Mathf.Abs(position.z);

            bool outX = posX >= _zoneRange;
            bool outY = posY >= _zoneRange || position.y < 0;
            bool outZ = posZ >= _zoneRange;

            if (outX || outY || outZ)
            {
                return true;
            }
            
            return false;
        }
    }
}
