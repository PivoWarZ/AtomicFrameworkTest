using Atomic.Entities;

namespace testAtomic
{
    public class HitPointsBehavior : IEntityInit
    {
        private IEntity _entity;
        
        void IEntityInit.Init(IEntity entity)
        {
            _entity = entity;
            
            entity.GetOnHit().Subscribe(TakeDamage);
        }

        private void TakeDamage(int damage)
        { 
            _entity.GetHitPoints().Value -= damage;

            float hitpoints = _entity.GetHitPoints().Value;

            if (hitpoints <= 0)
            {
                _entity.GetIsDead().Value = true;
            }
        }
    }
}
