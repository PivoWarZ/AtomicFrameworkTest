using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class RotateBehavior : IEntityLateUpdate
    {
        void IEntityLateUpdate.OnLateUpdate(IEntity entity, float deltaTime)
        {
            if (!entity.GetCanRotate().Value)
            {
                return;
            }

            var direction = entity.GetRotateDirection().Value;

            if (direction == Vector3.zero)
            {
                return;
            }

            var root = entity.GetEntityTransform();
            var rotateSpeed = entity.GetRotateSpeed().Value;
            var rotateDirection = Quaternion.LookRotation(direction, Vector3.up);
            root.rotation = Quaternion.Lerp(root.rotation, rotateDirection, rotateSpeed);
        }
    }
}
