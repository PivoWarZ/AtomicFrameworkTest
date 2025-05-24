using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class AttackRangeBehavior: IEntityUpdate
    {
        void IEntityUpdate.OnUpdate(IEntity entity, float deltaTime)
        {
            var distance = (entity.GetLoockAtTransform().position - entity.GetEntityTransform().position).magnitude;

            if (distance <= entity.GetEnemyAttackDistance().Value)
            {
                entity.GetIsAttackDistance().Value = true;
            }
            else
            {
                entity.GetIsAttackDistance().Value = false;
            }
        }
    }
}