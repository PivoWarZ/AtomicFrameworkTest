using System;
using Atomic.Elements;
using Atomic.Entities;
using UnityEngine;
using Event = Atomic.Elements.Event;

namespace ZombieShooter
{
    [Serializable]
    public class ShootInstall: IEntityInstaller
    {
        [SerializeField] private SceneEntity _bulletPrefab;
        [SerializeField] private Transform _shootPoint;
        [SerializeField] private Transform _bulletContainer;
        [SerializeField] private AndExpression _canShoot;
        
        [SerializeField] private BulletsLimitBehavior _bulletsLimitBehavior;
        [SerializeField] private ShootColdownBehavior _shootColdownBehavior;

        public void Install(IEntity entity)
        {
            entity.AddOnShootRequest(new Event());
            entity.AddOnShootAction(new Event());
            entity.AddOnShootEvent(new Event());
            
            entity.AddBulletPrefab(_bulletPrefab);
            entity.AddShootPoint(_shootPoint);
            entity.AddCanShoot(_canShoot);
            entity.AddBulletContainer(_bulletContainer);
            
            _bulletsLimitBehavior.Install(entity);
            _shootColdownBehavior.Install(entity);
            
            entity.AddBehaviour(_bulletsLimitBehavior);
            entity.AddBehaviour(_shootColdownBehavior);
        }
    }
}
