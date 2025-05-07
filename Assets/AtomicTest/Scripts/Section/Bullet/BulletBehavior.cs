using Atomic.Entities;
using Atomic.Elements;

namespace testAtomic
{
    public class BulletBehavior: IEntityInit, IEntityDispose
    {
        public void Init(IEntity entity)
        {
            entity.GetOnEntityTriggerEnter().Subscribe(OnTriggerEnter);
        }

        private void OnTriggerEnter(IEntity entity)
        {
            int damage = entity.GetBulletDamage();

            if (entity.TryGetOnHit(out var onHit))
            {
                onHit.Invoke(damage);
            }
        }

        public void Dispose(IEntity entity)
        {
            entity.GetOnEntityTriggerEnter().Unsubscribe(OnTriggerEnter);
        }
    }
}
