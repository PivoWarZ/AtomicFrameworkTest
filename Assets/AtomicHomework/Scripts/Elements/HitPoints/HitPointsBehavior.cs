using Atomic.Entities;
using Unity.Mathematics.Geometry;
using UnityEngine;

namespace ZombieShooter
{
    public class HitPointsBehavior : IEntityInit
    {
        private IEntity _entity;
        
        void IEntityInit.Init(IEntity entity)
        {
            _entity = entity;
            
            entity.GetOnTakeDamageAction().Subscribe(TakeDamage);
        }

        private void TakeDamage(float damage)
        {
            if (_entity.GetIsAlive().Value)
            {
                float hitpoints = _entity.GetHitPoints().Value;
                hitpoints = Mathf.Max(0, hitpoints - damage);
                _entity.GetHitPoints().Value = hitpoints;
                
                _entity.GetOnTakeDamageEvent().Invoke();
                    
                if (hitpoints <= 0)
                {
                    _entity.GetIsAlive().Value = false;
                    _entity.GetOnHitPointsEmpty().Invoke();
                }
            }
        }
    }
}
