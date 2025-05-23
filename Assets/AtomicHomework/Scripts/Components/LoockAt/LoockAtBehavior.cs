using Atomic.Entities;
using UnityEngine;

namespace ZombieShooter
{
    public class LoockAtBehavior : IEntityUpdate, IEntityFixedUpdate
    {
        private Vector3 _direction;
        private float _distance;
        
        public void OnUpdate(IEntity entity, float deltaTime)
        {
            _direction = entity.GetLoockAtTransform().position - entity.GetEntityTransform().position;
            _distance = _direction.magnitude;
        }
        
        void IEntityFixedUpdate.OnFixedUpdate(IEntity entity, float deltaTime)
        {
            if (_distance > entity.GetMinLoockDistance())
            {
                entity.GetRotateDirection().Value = _direction.normalized;
            }
        }

    }
}
