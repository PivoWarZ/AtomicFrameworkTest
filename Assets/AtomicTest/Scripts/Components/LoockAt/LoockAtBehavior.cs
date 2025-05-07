using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class LoockAtBehavior : IEntityFixedUpdate
    {
        void IEntityFixedUpdate.OnFixedUpdate(IEntity entity, float deltaTime)
        {
            var direction = (entity.GetLoockAtTransform().Value.position - entity.GetEntityTransform().position).normalized;

            entity.GetRotateDirection().Value = direction;

        }
    }
}
