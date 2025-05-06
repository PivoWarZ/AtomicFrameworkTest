using Atomic.Entities;

namespace testAtomic
{
    public class HitPointsBehavior : IEntityInit
    {
        void IEntityInit.Init(IEntity entity)
        {
            entity.GetOnHitEvent().Subscribe(TakeDamage);
        }

        private void TakeDamage(IEntity entity, int damage)
        { 
            entity.GetHitPoints().Value -= damage;

            float hitpoints = entity.GetHitPoints().Value;

            if (hitpoints <= 0)
            {
                entity.GetIsDead().Value = true;
            }
        }
    }
}
