using Atomic.Entities;
using UnityEngine;

namespace testAtomic
{
    public class ShootBehavior : IEntityDispose, IEntityEnable
    {

        public void Shoot(IEntity entity)
        {
            if (entity.GetCanShoot().Value)
            {
                Debug.Log("Shoot");
                var bulletPrefab = entity.GetBulletPrefab();
                var shootPoint = entity.GetShootPoint();

                var bullet = SceneEntity.Instantiate(bulletPrefab, shootPoint.position, Quaternion.identity);

                bullet.GetMoveDirection().Value = shootPoint.forward;

                entity.GetOnShootFired().Invoke();
            }
        }
        
        void IEntityEnable.Enable(IEntity entity)
        {
            entity.GetOnShoot().Subscribe(Shoot);
        }
        void IEntityDispose.Dispose(IEntity entity)
        {
            entity.GetOnShoot().Unsubscribe(Shoot);
        }
    }
}
